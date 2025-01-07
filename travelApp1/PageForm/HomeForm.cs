using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using travelApp1.Helpers;
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


            if (Properties.Settings.Default.AccessToken != "")
            {
                btnSignIn.Visible = false;
                btnSignUp.Visible = false;
                btnSignOut.Visible = true;

                lblUserInfo.Text = "Xin chào, " + UserIndentity.Email;

            }
            else
            {
                btnSignIn.Visible = true;
                btnSignUp.Visible = true;
                btnSignOut.Visible = false;
                btnAccount.Visible = false;

                lblUserInfo.Text = "Bạn chưa đăng nhập!";

            }

            if (UserIndentity.Role == "admin")
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }

            logoPictureBox.Image = Image.FromFile("Images/logo.png");


            // Initialize the panel for slides
            slidePanel = new Panel
            {
                Width = 800,  // Set an initial width
                Height = 400, // Set an initial height
                Location = new Point(200, 50), // Adjust the location as needed
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            // Initialize the picture box for displaying slides
            slidePicture = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };

            // Add slidePicture to slidePanel
            slidePanel.Controls.Add(slidePicture);
            this.Controls.Add(slidePanel); // Add slidePanel to the form

            // Set up slide images
            slideImages = new string[]
            {
        "Images/image1.jpg",
        "Images/image2.jpg",
        "Images/image3.jpg"
            };

            // Initialize the timer for automatic slide transitions
            slideTimer = new System.Windows.Forms.Timer
            {
                Interval = 3000 // Change slide every 3 seconds
            };
            slideTimer.Tick += SlideTimer_Tick;
            slideTimer.Start();

            // Load logo


            // Initialize current slide index and update the first slide
            currentSlideIndex = 0;
            UpdateSlide();
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
            TourForm tourForm = new TourForm();
            tourForm.Show();
        }

        private void BtnBooking_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã chọn 'Đặt Tour'. Tính năng này đang được phát triển!");
        }

        //Sự kiện khi nhấn nút "Tour"
        private void BtnTour_Click(object? sender, EventArgs e)
        {
            TourForm tourForm = new TourForm();
            tourForm.Show(); // Hiển thị form Tour
        }

        // Sự kiện khi nhấn nút "Profile"
        private void BtnProfile_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                ProfileForm profileForm = new ProfileForm();
                profileForm.Show(); // Hiển thị form Profile
            }
            else
            {
                MessageBox.Show("Bạn cần đăng nhập để xem thông tin cá nhân!");
            }

        }

        // Sự kiện khi nhấn nút "Account"
        private void BtnAccount_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                AccountForm accountForm = new AccountForm();
                accountForm.Show(); // Hiển thị form Account
            }
            else
            {
                MessageBox.Show("Bạn cần đăng nhập để xem thông tin tài khoản!");
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TourForm tourForm = new TourForm();
            tourForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                TourForm tourForm = new TourForm();
                tourForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần đăng nhập để đặt tour!");
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Signin signinForm = new Signin();
            signinForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccessToken = "";
            Properties.Settings.Default.Save();

            btnSignIn.Visible = true;
            btnSignUp.Visible = true;
            btnSignOut.Visible = false;

            lblUserInfo.Text = "Bạn chưa đăng nhập!";
        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                MessageBox.Show("Bạn cần đăng nhập để xem booking!");
            }
            else
            {
                var form = new BookingManageForm();
                form.Show();
                this.Hide();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var form = new AdminForm();
            form.Show();
            this.Hide();
        }
    }



}
