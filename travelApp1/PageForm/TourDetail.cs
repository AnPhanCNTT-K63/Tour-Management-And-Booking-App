using Newtonsoft.Json;
using System.Diagnostics;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class TourDetail : Form
    {
        private readonly TourDTO _tour;
        private List<PackageDTO> _packages;
        private readonly ApiService _service;
        private Label selectedScheduleLabel = null;
        private Label selectedVoucherLabel = null;
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
            lblName.Text = $"Name: {_tour.Name}";
            lblRegion.Text = $"Region: {_tour.Region}";
            lblCountry.Text = $"Country: {_tour.Country}";
            lblCity.Text = $"City: {_tour.City}";
            lblDescription.Text = $"Description: {_tour.Description ?? "N/A"}";
            lblOpening.Text = $"Opening Date: {_tour.Opening.ToString("yyyy-MM-dd")}";
            lblEnding.Text = $"Ending Date: {_tour.Ending.ToString("yyyy-MM-dd")}";

            pictureBox.ImageLocation = $"{CloudHelper.CloudUri}/Tours/{_tour.Image}";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            // Styling the labels for better visual appeal
            lblName.Font = new Font("Arial", 14, FontStyle.Bold);
            lblRegion.Font = new Font("Arial", 12, FontStyle.Regular);
            lblCountry.Font = new Font("Arial", 12, FontStyle.Regular);
            lblCity.Font = new Font("Arial", 12, FontStyle.Regular);
            lblDescription.Font = new Font("Arial", 10, FontStyle.Italic);
            lblOpening.Font = new Font("Arial", 12, FontStyle.Regular);
            lblEnding.Font = new Font("Arial", 12, FontStyle.Regular);

            lblName.ForeColor = Color.Black;
            lblRegion.ForeColor = Color.Black;
            lblCountry.ForeColor = Color.Black;
            lblCity.ForeColor = Color.Black;
            lblDescription.ForeColor = Color.DarkGreen;
            lblOpening.ForeColor = Color.Black;
            lblEnding.ForeColor = Color.Black;
        }


        private void DisplayTourPackages(List<PackageDTO> packages)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var package in packages)
            {
                var panel = new Panel
                {
                    Width = flowLayoutPanel1.Width - 30,
                    Height = 340,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    Tag = package
                };

                // Package Image
                var pictureBox = new PictureBox
                {
                    Width = 150,
                    Height = 150,
                    ImageLocation = $"{CloudHelper.CloudUri}/Packages/{package.Image}",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, 10)
                };

                // Package Name
                var nameLabel = new Label
                {
                    Text = $"Name: {package.Name ?? "N/A"}",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(180, 10)
                };

                // Package Description
                var descriptionLabel = new Label
                {
                    Text = $"Description: {package.Description ?? "N/A"}",
                    AutoSize = false,
                    Width = panel.Width - 200,
                    Height = 50,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(180, 40)
                };

                // Package Price
                var priceLabel = new Label
                {
                    Text = $"Price: ${package.Price ?? 0}",
                    AutoSize = true,
                    Font = new Font("Arial", 11, FontStyle.Regular),
                    ForeColor = Color.DarkGreen,
                    Location = new Point(180, 100)
                };

                // Schedules Section
                var schedulesTitleLabel = new Label
                {
                    Text = "Schedules:",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(10, 180)
                };

                panel.Controls.Add(schedulesTitleLabel);

                int scheduleY = 200;
                if (package.Schedules != null && package.Schedules.Any())
                {
                    foreach (var schedule in package.Schedules)
                    {
                        var scheduleLabel = new Label
                        {
                            Text = schedule.TravelDay.ToString("yyyy-MM-dd"),
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Regular),
                            ForeColor = Color.Blue,
                            Cursor = Cursors.Hand,
                            Location = new Point(10, scheduleY),
                            Tag = schedule
                        };

                        scheduleLabel.Click += (sender, e) =>
                        {
                            HighlightSelectedLabel(ref selectedScheduleLabel, scheduleLabel);
                        };

                        panel.Controls.Add(scheduleLabel);
                        scheduleY += 25;
                    }
                }
                else
                {
                    var noScheduleLabel = new Label
                    {
                        Text = "N/A",
                        AutoSize = true,
                        Font = new Font("Arial", 9, FontStyle.Regular),
                        ForeColor = Color.Gray,
                        Location = new Point(10, scheduleY)
                    };
                    panel.Controls.Add(noScheduleLabel);
                }

                // Vouchers Section
                var vouchersTitleLabel = new Label
                {
                    Text = "Vouchers:",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(180, 180)
                };

                panel.Controls.Add(vouchersTitleLabel);

                int voucherY = 200;
                if (package.Vouchers != null && package.Vouchers.Any())
                {
                    foreach (var voucher in package.Vouchers)
                    {
                        var voucherLabel = new Label
                        {
                            Text = voucher.Code,
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Regular),
                            ForeColor = Color.Green,
                            Cursor = Cursors.Hand,
                            Location = new Point(180, voucherY),
                            Tag = voucher
                        };

                        voucherLabel.Click += (sender, e) =>
                        {
                            HighlightSelectedLabel(ref selectedVoucherLabel, voucherLabel);
                        };

                        panel.Controls.Add(voucherLabel);
                        voucherY += 25;
                    }
                }
                else
                {
                    var noVoucherLabel = new Label
                    {
                        Text = "N/A",
                        AutoSize = true,
                        Font = new Font("Arial", 9, FontStyle.Regular),
                        ForeColor = Color.Gray,
                        Location = new Point(180, voucherY)
                    };
                    panel.Controls.Add(noVoucherLabel);
                }

                // Book Now Button
                var btnBook = new Button
                {
                    Text = "Book Now",
                    Width = 120,
                    Height = 35,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(panel.Width - 140, panel.Height - 50),
                    Tag = package
                };

                btnBook.Click += (sender, e) =>
                {
                    if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
                    {
                        MessageBox.Show("You need to login to book a package", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    BookPackage(sender, panel);
                };

                // Add controls to the panel
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(descriptionLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(btnBook);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void HighlightSelectedLabel(ref Label selectedLabel, Label newLabel)
        {
            // Deselect the previous label
            if (selectedLabel != null)
            {
                selectedLabel.BackColor = Color.Transparent;
            }

            // Select the new label
            newLabel.BackColor = Color.LightGray;
            selectedLabel = newLabel;
        }
        private void BookPackage(object sender, Panel panel)
        {
            var clickedButton = sender as Button;
            if (clickedButton != null)
            {
                var selectedPackage = (PackageDTO)clickedButton.Tag;

                var selectedSchedule = panel.Controls.OfType<Label>()
                    .Where(lbl => lbl.BackColor == Color.LightGray && lbl.Tag is ScheduleDTO)
                    .Select(lbl => (ScheduleDTO)lbl.Tag)
                    .FirstOrDefault();

                var selectedVoucher = panel.Controls.OfType<Label>()
                    .Where(lbl => lbl.BackColor == Color.LightGray && lbl.Tag is VoucherDTO)
                    .Select(lbl => (VoucherDTO)lbl.Tag)
                    .FirstOrDefault();

                var form = new Booking(selectedPackage, _tour, selectedSchedule?.TravelDay.ToString("yyyy-MM-dd"), selectedVoucher?.Code);
                form.Show();
                this.Hide();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
