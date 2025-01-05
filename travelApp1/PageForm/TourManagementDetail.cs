using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Helpers;
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
        private bool _isImageChanged = false;
        private string _newImagePath = string.Empty;
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
            txtImage.Text = _tour.Image;
            Image image = await LoadImageFromUrl($"{CloudHelper.CloudUri}/Tours/{_tour.Image}");
            TourImage.Image = image;
            TourImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns["Id"].ReadOnly = true;

            dataGridView1.Columns.Add("Name", "Package Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Activities", "Activities");
            dataGridView1.Columns.Add("IsChangeSchedule", "Change Schedule");
            dataGridView1.Columns.Add("IsRefund", "Refundable");
            dataGridView1.Columns.Add("CheckIn", "Check-In");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Vat", "VAT");
            dataGridView1.Columns.Add("ImageName", "ImageName");


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

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private async void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


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
                dataGridView1.Rows[rowIndex].Cells["ImageName"].Value = package.Image;

                if (!string.IsNullOrEmpty(package.Image))
                {
                    try
                    {
                        Image packageImage = await LoadImageFromUrl($"{CloudHelper.CloudUri}/Packages/{package.Image}");
                        dataGridView1.Rows[rowIndex].Cells["Image"].Value = packageImage;
                    }
                    catch
                    {
                        dataGridView1.Rows[rowIndex].Cells["Image"].Value = null;
                    }
                }
            }
        }

        private async Task<Image> LoadImageFromUrl(string imageUrl)
        {
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
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
                // Upload new image if it was changed
                if (_isImageChanged && !string.IsNullOrEmpty(_newImagePath))
                {
                    using (var fileStream = new System.IO.FileStream(_newImagePath, System.IO.FileMode.Open))
                    using (var httpClient = new System.Net.Http.HttpClient())
                    {
                        var content = new MultipartFormDataContent();

                        var fileContent = new StreamContent(fileStream);
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                        content.Add(fileContent, "file", Path.GetFileName(_newImagePath));

                        content.Add(new StringContent("Tours"), "folder");

                        var response = await httpClient.PostAsync("https://localhost:7025/api/cloud/upload", content);
                        if (response.IsSuccessStatusCode)
                        {
                            var uploadedImagePath = await response.Content.ReadAsStringAsync();
                            _tour.Image = Path.GetFileName(uploadedImagePath); // Update the tour image path
                        }
                        else
                        {
                            var errorMessage = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to upload image: {errorMessage}", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Prepare the updated tour DTO
                var updateTourDto = new UpdateTourDTO
                {
                    Name = txtTourName.Text.Trim(),
                    Region = txtRegion.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Image = _tour.Image.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Opening = DateTime.TryParse(txtOpening.Text, out var openingDate) ? openingDate : (DateTime?)null,
                    Ending = DateTime.TryParse(txtEnding.Text, out var endingDate) ? endingDate : (DateTime?)null
                };

                // Send the updated tour to the API
                var res = await _service.PutAsync($"tour/update/{_tourId}", updateTourDto);

                if (res.IsSuccessStatusCode)
                {
                    // Prepare updated packages
                    var updatedPackages = new List<PackageDTO>();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var package = new PackageDTO
                        {
                            Id = Convert.ToInt32(row.Cells["Id"].Value),
                            Name = row.Cells["Name"].Value?.ToString(),
                            Description = row.Cells["Description"].Value?.ToString(),
                            Price = decimal.TryParse(row.Cells["Price"].Value?.ToString().Replace("$", "").Trim(), out var price) ? price : (decimal?)null,
                            Image = row.Cells["ImageName"].Value?.ToString(),
                            Activities = row.Cells["Activities"].Value?.ToString(),
                            IsChangeSchedule = row.Cells["IsChangeSchedule"].Value?.ToString() == "Yes",
                            IsRefund = row.Cells["IsRefund"].Value?.ToString() == "Yes",
                            CheckIn = row.Cells["CheckIn"].Value?.ToString(),
                            Quantity = int.TryParse(row.Cells["Quantity"].Value?.ToString(), out var quantity) ? quantity : (int?)null,
                            Vat = decimal.TryParse(row.Cells["Vat"].Value?.ToString(), out var vat) ? vat : (decimal?)null
                        };

                        updatedPackages.Add(package);
                    }

                    // Update packages via API
                    foreach (var package in updatedPackages)
                    {
                        var packageRes = await _service.PutAsync($"package/update/{package.Id}", package);
                        Debug.WriteLine(JsonConvert.SerializeObject(package, Formatting.Indented));

                        if (!packageRes.IsSuccessStatusCode)
                        {
                            var errorMessage = await packageRes.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to update package ID {package.Id}: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("Tour updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void btnChangePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Tour Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        var fileInfo = new System.IO.FileInfo(filePath);

                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Please select an image smaller than 5 MB.", "File Size Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        using (var fs = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            var image = Image.FromStream(fs);
                            TourImage.Image = new Bitmap(image);
                        }

                        txtImage.Text = Path.GetFileName(filePath);
                        _isImageChanged = true;
                        _newImagePath = filePath;

                        MessageBox.Show("Tour image changed successfully. Click Save to upload.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while changing the picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



    }

}
