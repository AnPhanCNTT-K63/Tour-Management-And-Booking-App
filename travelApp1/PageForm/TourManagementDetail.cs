using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1
{
    public partial class TourManagementDetail : Form
    {
        private readonly int _tourId;
        private TourDTO _tour;
        private List<PackageDTO> _packages;
        private readonly ApiService _service;
        public TourManagementDetail(int tourId)
        {
            InitializeComponent();

            _tourId = tourId;
            _tour = new TourDTO();
            _packages = new List<PackageDTO>();
            _service = new ApiService();

            LoadTour();
            InitializeDataGridView();
            LoadTourPackages();

        }
        private async void LoadTour()
        {

            try
            {
                var res = await _service.GetAsync($"tour/{_tourId}");

                if (res.IsSuccessStatusCode)
                {
                    var tourJson = await res.Content.ReadAsStringAsync();
                    var tourDetail = JsonConvert.DeserializeObject<TourDTO>(tourJson);

                    _tour = tourDetail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtID.Text = _tour.Id.ToString();
            txtUserId.Text = _tour.UserId.ToString();
            txtTourName.Text = _tour.Name;
            txtCity.Text = _tour.City;
            txtRegion.Text = _tour.Region;
            txtCountry.Text = _tour.Country;
            txtOpening.Text = _tour.Opening.ToString("dd/MM/yyyy");
            txtEnding.Text = _tour.Ending.ToString("dd/MM/yyyy");
            txtCreatedAt.Text = _tour.CreatedAt.ToString("dd/MM/yyyy");
            txtDescription.Text = _tour.Description;

        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Package Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Activities", "Activities");
            dataGridView1.Columns.Add("IsChangeSchedule", "Change Schedule");
            dataGridView1.Columns.Add("IsRefund", "Refundable");
            dataGridView1.Columns.Add("CheckIn", "Check-In");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Vat", "VAT");

            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imageColumn);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private async void LoadTourPackages()
        {

            try
            {
                var res = await _service.GetAsync($"package/tour/{_tourId}");

                if (res.IsSuccessStatusCode)
                {
                    var packagesJson = await res.Content.ReadAsStringAsync();
                    var packages = JsonConvert.DeserializeObject<List<PackageDTO>>(packagesJson);
                    _packages = packages;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (_packages == null || !_packages.Any())
            {
                MessageBox.Show("No packages available for this tour.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.Rows.Clear();

            foreach (var package in _packages)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Id"].Value = package.Id;
                dataGridView1.Rows[rowIndex].Cells["Name"].Value = package.Name;
                dataGridView1.Rows[rowIndex].Cells["Description"].Value = package.Description;
                dataGridView1.Rows[rowIndex].Cells["Price"].Value = package.Price?.ToString("C");
                dataGridView1.Rows[rowIndex].Cells["Activities"].Value = package.Activities;
                dataGridView1.Rows[rowIndex].Cells["IsChangeSchedule"].Value = package.IsChangeSchedule == true ? "Yes" : "No";
                dataGridView1.Rows[rowIndex].Cells["IsRefund"].Value = package.IsRefund == true ? "Yes" : "No";
                dataGridView1.Rows[rowIndex].Cells["CheckIn"].Value = package.CheckIn;
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = package.Quantity;
                dataGridView1.Rows[rowIndex].Cells["Vat"].Value = package.Vat?.ToString("0.00");

                if (!string.IsNullOrEmpty(package.Image))
                {
                    try
                    {
                        Image packageImage = LoadImageFromUrl("https://d3omtf52mksen3.cloudfront.net/Tours/ba_be_lake.jpg");
                        dataGridView1.Rows[rowIndex].Cells["Image"].Value = packageImage;
                    }
                    catch
                    {
                        dataGridView1.Rows[rowIndex].Cells["Image"].Value = null;
                    }
                }
            }
        }

        private Image LoadImageFromUrl(string imageUrl)
        {
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var imageBytes = httpClient.GetByteArrayAsync(imageUrl).Result;
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }


        private void AddTourButton_Click(object sender, EventArgs e)
        {
        }

        private void EditTourButton_Click(object sender, EventArgs e)
        {

        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await _service.DeleteAsync($"tour/soft-delete/{_tourId}");

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tour has been deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to delete tour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var updateTourDto = new UpdateTourDTO
                {
                    Name = txtTourName.Text.Trim(),
                    Region = txtRegion.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Opening = DateTime.TryParse(txtOpening.Text, out var openingDate) ? openingDate : (DateTime?)null,
                    Ending = DateTime.TryParse(txtEnding.Text, out var endingDate) ? endingDate : (DateTime?)null
                };

                var res = await _service.PutAsync($"tour/update/{_tourId}", updateTourDto);

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tour has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    var errorMessage = await res.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to update tour: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
