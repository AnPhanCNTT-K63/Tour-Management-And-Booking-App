using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using RestSharp;
using Newtonsoft.Json;

using travelApp1.PageForm;

namespace travelApp1
{
    public partial class CreateTour : Form
    {
        public CreateTour()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "Images", "default.jpg");

        }

        private void CreateTour_Load(object sender, EventArgs e)
        {

        }

        private async void btnAddTour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImage.Text))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh cho tour.");
                return;
            }

            // Upload the tour image
            var tourImagePath = txtImage.Text;
            var uploadResult = await UploadImageAsync(tourImagePath, "Tours");
            if (string.IsNullOrEmpty(uploadResult))
            {
                MessageBox.Show("Không thể tải lên hình ảnh tour.");
                return;
            }

            var tourDTO = new TourDTO
            {
                Name = txtName.Text,
                Region = txtRegion.Text,
                Country = txtCountry.Text,
                City = txtCity.Text,
                Image = uploadResult,
                Description = txtDescription.Text,
                Opening = dtpOpening.Value,
                Ending = dtpEnding.Value
            };

            string validationError = tourDTO.GetValidationError();
            if (validationError != null)
            {
                MessageBox.Show(validationError);
                return;
            }

            var createTourPackageForm = new CreateTourPackage(tourDTO, this);
            createTourPackageForm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtRegion.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtImage.Clear();
            txtDescription.Clear();
            dtpOpening.Value = DateTime.Now;
            dtpEnding.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để chọn file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ cho phép chọn file ảnh
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đầy đủ của file
                    string fullFilePath = openFileDialog.FileName;

                    // Lấy tên file từ đường dẫn và gán vào txtImage (nếu cần hiển thị)
                    txtImage.Text = fullFilePath; // Use full file path here

                    // Hiển thị ảnh trong pictureBox1
                    pictureBox1.Image = Image.FromFile(fullFilePath);

                    // Sao chép ảnh vào thư mục lưu trữ (nếu cần)
                    string destinationPath = System.IO.Path.Combine(Application.StartupPath, "Images", System.IO.Path.GetFileName(fullFilePath));
                    if (!System.IO.Directory.Exists(System.IO.Path.Combine(Application.StartupPath, "Images")))
                    {
                        System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.StartupPath, "Images"));
                    }
                    System.IO.File.Copy(fullFilePath, destinationPath, true); // Ghi đè nếu file tồn tại
                }
            }
        }


        private async Task<string> UploadImageAsync(string imagePath, string folder)
        {
            using (var client = new RestClient($"{Properties.Settings.Default.ApiUrl}"))
            {
                var request = new RestRequest("cloud/upload", Method.Post);
                request.AddFile("file", imagePath);
                request.AddParameter("folder", folder);

                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    // Assuming the API returns the uploaded file's full path or URL
                    string uploadedImageUrl = response.Content.Trim('"');
                    string imageName = Path.GetFileName(uploadedImageUrl); // Extract only the image name
                    return imageName;
                }
                else
                {
                    MessageBox.Show($"Failed to upload image:", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

    }
}



