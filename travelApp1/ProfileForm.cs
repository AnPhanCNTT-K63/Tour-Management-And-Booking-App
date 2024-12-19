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

namespace travelApp1
{
    public partial class ProfileForm : Form
    {
        private readonly string apiBaseUrl = "https://localhost:7025"; // Thay bằng URL của API
        private readonly int userId = 1; // ID người dùng cần lấy, có thể truyền từ tham số khác

        public ProfileForm()
        {
            InitializeComponent();
            LoadProfileAsync();
        }

        private async void LoadProfileAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiBaseUrl}/api/user/{userId}/profile");

                    if (response.IsSuccessStatusCode)
                    {

                        var profile = await response.Content.ReadFromJsonAsync<UserProfile>();
                        if (profile != null)
                        {
                            // Map dữ liệu từ profile vào các TextBox
                            txtFirstName.Text = profile.FirstName;
                            txtLastName.Text = profile.LastName;
                            emailTextBox.Text = profile.Email;
                            phoneTextBox.Text = profile.Phone;
                            txtAdress.Text = profile.Address;
                            txtCity.Text = profile.City;
                            txtCountry.Text = profile.Country;
                            txtPostalCode.Text = profile.PostalCode.ToString();
                            richTextBox1.Text = profile.AboutMe;

                            // Nếu cần hiển thị ảnh avatar
                            if (!string.IsNullOrEmpty(profile.Avatar))
                            {
                                avatarPictureBox.Load(profile.Avatar);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.ReasonPhrase}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button changeAvatarButton;


        public class UserProfile
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public int PostalCode { get; set; }
            public string AboutMe { get; set; }
            public string Avatar { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
        // Xử lý sự kiện lưu thông tin
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Lưu thông tin profile ở đây (ví dụ: ghi vào file, database, hoặc thông báo)
            MessageBox.Show("Profile saved!");
        }

        // Xử lý sự kiện hủy bỏ
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Đóng form hoặc quay lại màn hình trước
            this.Close();
        }

        // Xử lý thay đổi avatar
        private void ChangeAvatarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Lọc các loại file hình ảnh
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.avatarPictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
