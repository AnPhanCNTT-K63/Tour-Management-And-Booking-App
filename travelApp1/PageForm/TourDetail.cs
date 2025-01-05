using Newtonsoft.Json;
using System.Diagnostics;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class TourDetail : Form
    {
        private readonly TourDTO _tour;
        private List<PackageDTO> _packages;
        private readonly ApiService _service;
        public TourDetail(TourDTO tour)
        {
            InitializeComponent();
            _tour = tour;
            _service = new ApiService();
            _packages = new List<PackageDTO>();
            InitData();
            flowLayoutPanel1.AutoScroll = true;
        }

        private async void InitData()
        {
            DisplayTourDetails();

            try
            {
                var res = await _service.GetAsync($"package/tour/{_tour.Id}");

                if (!res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error while fetching package details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var packageJson = await res.Content.ReadAsStringAsync();
                if (packageJson.StartsWith("["))
                {
                    // Deserialize as a list
                    _packages = JsonConvert.DeserializeObject<List<PackageDTO>>(packageJson);
                }
                else
                {
                    // Deserialize as a single object and wrap it into a list
                    var package = JsonConvert.DeserializeObject<PackageDTO>(packageJson);
                    _packages = new List<PackageDTO> { package };
                }

                DisplayTourPackages(_packages);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayTourDetails()
        {
            lblName.Text = _tour.Name;
            lblRegion.Text = _tour.Region;
            lblCountry.Text = _tour.Country;
            lblCity.Text = _tour.City;
            pictureBox.ImageLocation = _tour.Image;
        }

        private void DisplayTourPackages(List<PackageDTO> packages)
        {
            flowLayoutPanel1.Controls.Clear();
            Label selectedScheduleLabel = null; // Track the currently selected schedule
            Label selectedVoucherLabel = null; // Track the currently selected voucher

            foreach (var package in packages)
            {
                var panel = new Panel
                {
                    Width = flowLayoutPanel1.Width - 20,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    Tag = package
                };

                // Package Name
                var nameLabel = new Label
                {
                    Text = $"Name: {package.Name ?? "N/A"}", // Null check for Name
                    Width = panel.Width - 20,
                    Location = new Point(10, 10),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black
                };

                // Package Image
                var pictureBox = new PictureBox
                {
                    Width = 120,
                    Height = 120,
                    ImageLocation = package.Image ?? "", // Null check for Image
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 40)
                };

                // Package Price
                var priceLabel = new Label
                {
                    Text = $"Price: ${package.Price ?? 0}", // Null check for Price
                    Width = panel.Width - 140,
                    Location = new Point(130, 40),
                    ForeColor = Color.Black
                };

                // Schedules (Left side)
                var schedulesLabel = new Label
                {
                    Text = "Schedules:",
                    Width = (panel.Width / 2) - 20,
                    Location = new Point(10, 170),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black
                };

                panel.Controls.Add(schedulesLabel);

                int scheduleY = 190;
                if (package.Schedules != null && package.Schedules.Any())
                {
                    foreach (var schedule in package.Schedules)
                    {
                        var scheduleLabel = new Label
                        {
                            Text = schedule.TravelDay.ToString("yyyy-MM-dd"),
                            Width = (panel.Width / 2) - 20,
                            Location = new Point(10, scheduleY),
                            ForeColor = Color.Blue,
                            Cursor = Cursors.Hand,
                            Tag = schedule,
                        };

                        scheduleLabel.Click += (sender, e) =>
                        {
                            // Deselect the previous schedule
                            if (selectedScheduleLabel != null)
                            {
                                selectedScheduleLabel.BackColor = Color.Transparent;
                            }

                            // Select the current schedule
                            scheduleLabel.BackColor = Color.LightGray;
                            selectedScheduleLabel = scheduleLabel; // Update the selected schedule
                        };

                        panel.Controls.Add(scheduleLabel);
                        scheduleY += 30;
                    }
                }
                else
                {
                    var noScheduleLabel = new Label
                    {
                        Text = "N/A",
                        Width = (panel.Width / 2) - 20,
                        Location = new Point(10, scheduleY),
                        ForeColor = Color.Black
                    };
                    panel.Controls.Add(noScheduleLabel);
                }

                // Vouchers (Right side)
                var vouchersLabel = new Label
                {
                    Text = "Vouchers:",
                    Width = (panel.Width / 2) - 20,
                    Location = new Point((panel.Width / 2) + 10, 170),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black
                };

                panel.Controls.Add(vouchersLabel);

                int voucherY = 190;
                if (package.Vouchers != null && package.Vouchers.Any())
                {
                    foreach (var voucher in package.Vouchers)
                    {
                        var voucherLabel = new Label
                        {
                            Text = voucher.Code,
                            Width = (panel.Width / 2) - 20,
                            Location = new Point((panel.Width / 2) + 10, voucherY),
                            ForeColor = Color.Green,
                            Cursor = Cursors.Hand, // Make it look clickable
                            Tag = voucher
                        };

                        voucherLabel.Click += (sender, e) =>
                        {
                            // Check if this voucher is already selected
                            if (selectedVoucherLabel == voucherLabel)
                            {
                                // Unselect the voucher
                                voucherLabel.BackColor = Color.Transparent;
                                selectedVoucherLabel = null; // Clear the selection
                            }
                            else
                            {
                                // Select the current voucher
                                if (selectedVoucherLabel != null)
                                {
                                    selectedVoucherLabel.BackColor = Color.Transparent; // Deselect the previous one
                                }

                                voucherLabel.BackColor = Color.LightGray;
                                selectedVoucherLabel = voucherLabel; // Update the selected voucher
                            }
                        };

                        panel.Controls.Add(voucherLabel);
                        voucherY += 30;
                    }
                }
                else
                {
                    var noVoucherLabel = new Label
                    {
                        Text = "N/A",
                        Width = (panel.Width / 2) - 20,
                        Location = new Point((panel.Width / 2) + 10, voucherY),
                        ForeColor = Color.Black
                    };
                    panel.Controls.Add(noVoucherLabel);
                }

                // Add the Book Now button
                var btnBook = new Button
                {
                    Text = "Book Now",
                    Width = 100,
                    Height = 30,
                    Location = new Point(panel.Width - 120, 130),
                    Tag = package

                };

                btnBook.Click += (sender, e) =>
                {
                    var clickedButton = sender as Button;
                    if (clickedButton != null)
                    {
                        // Retrieve the associated package
                        var selectedPackage = (PackageDTO)clickedButton.Tag;

                        // You can also check for the selected schedule or voucher here
                        var selectedSchedule = panel.Controls.OfType<Label>()
                            .Where(lbl => lbl.BackColor == Color.LightGray && lbl.Tag is ScheduleDTO)
                            .Select(lbl => (ScheduleDTO)lbl.Tag)
                            .FirstOrDefault();

                        var selectedVoucher = panel.Controls.OfType<Label>()
                            .Where(lbl => lbl.BackColor == Color.LightGray && lbl.Tag is VoucherDTO)
                            .Select(lbl => (VoucherDTO)lbl.Tag)
                            .FirstOrDefault();


                        var form = new Booking(selectedPackage, _tour, selectedSchedule?.TravelDay.ToString("yyyy-MM-dd"), selectedVoucher.Code);
                        form.Show();
                        this.Hide();
                    }
                };

                // Add controls to the panel
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(btnBook);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TourForm t = new TourForm();
            this.Close();
        }
    }
}
