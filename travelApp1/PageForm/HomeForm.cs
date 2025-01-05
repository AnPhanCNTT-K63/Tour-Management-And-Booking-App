using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.PageForm;

namespace travelApp1
{
    public partial class HomeForm : Form
    {
        private Panel slidePanel;          // Panel chứa các slide
        private PictureBox slidePicture;   // Hiển thị hình ảnh slide
        private System.Windows.Forms.Timer slideTimer;          // Timer để tự động chuyển slide
        private int currentSlideIndex;     // Chỉ mục slide hiện tại
        private string[] slideImages;      // Mảng chứa đường dẫn các hình ảnh
        private PictureBox logoPictureBox;
        public HomeForm()
        {
            InitializeComponent();

            slideImages = new string[]
           {
                            "Images/image1.jpg",
                            "Images/image2.jpg",
                            "Images/image3.jpg"
           };
            logoPictureBox.Image = Image.FromFile("Images/logo.png");  // Thay đường dẫn chính xác đến logo

            TourManagerForm tourM = new TourManagerForm();

        }

        // Hàm cập nhật slide
        private void UpdateSlide()
        {
            if (slideImages.Length > 0)
            {
                slidePicture.Image = Image.FromFile(slideImages[currentSlideIndex]);
            }
        }

        // Sự kiện Timer: chuyển sang slide tiếp theo
        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            currentSlideIndex++;
            if (currentSlideIndex >= slideImages.Length)
            {
                currentSlideIndex = 0; // Quay lại slide đầu tiên
            }
            UpdateSlide();
        }


        private void BtnViewTour_Click(object? sender, EventArgs e)
        {
            tourForm.Show();
        }

        private void BtnBooking_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn 'Đặt Tour'. Tính năng này đang được phát triển!");
        }

        //Sự kiện khi nhấn nút "Tour"
        private void BtnTour_Click(object? sender, EventArgs e)
        {
            tourForm.Show(); // Hiển thị form Tour
        }

        // Sự kiện khi nhấn nút "Profile"
        private void BtnProfile_Click(object? sender, EventArgs e)
        {
            profileForm.Show(); // Hiển thị form Profile
        }

        // Sự kiện khi nhấn nút "Account"
        private void BtnAccount_Click(object? sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show(); // Hiển thị form Account
        }

    }



}
