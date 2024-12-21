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

namespace travelApp1
{
    public partial class CreateTour : Form
    {
        public CreateTour()
        {
            InitializeComponent();
        }

        private void CreateTour_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            var tourDTO = new TourDTO
            {
                Name = txtName.Text,
                Region = txtRegion.Text,
                Country = txtCountry.Text,
                City = txtCity.Text,
                Image = txtImage.Text,
                Description = txtDescription.Text,
                Opening = dtpOpening.Value,
                Ending = dtpEnding.Value
            };

            // Kiểm tra tính hợp lệ của TourDTO
            string validationError = tourDTO.GetValidationError();
            if (validationError != null)
            {
                MessageBox.Show(validationError);
                return;
            }

            // Mở form CreateTourPackage và truyền TourDTO sang
            var createTourPackageForm = new CreateTourPackage(tourDTO, this);
            createTourPackageForm.Show();
            this.Hide();
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
                    // Lấy tên file từ đường dẫn
                    string fileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                    // Gán tên file vào txtPackageImage
                    txtImage.Text = fileName;

                    // Sao chép ảnh vào thư mục lưu trữ (nếu cần)
                    string destinationPath = System.IO.Path.Combine(Application.StartupPath, "Images", fileName);
                    if (!System.IO.Directory.Exists(System.IO.Path.Combine(Application.StartupPath, "Images")))
                    {
                        System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.StartupPath, "Images"));
                    }
                    System.IO.File.Copy(openFileDialog.FileName, destinationPath, true); // Ghi đè nếu file tồn tại
                }
            }
        }
    }
}
    


