using RestSharp;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models; 

namespace travelApp1.PageForm
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
            this.Load += EditProfileForm_Load; // Đăng ký sự kiện Load
        }

        // Hàm gọi API để lấy dữ liệu Profile
        private async Task<ProfileDTO> GetProfileAsync(int userId)
        {
            string apiUrl = $"https://localhost:7025/api/user/{userId}/profile";
            var client = new RestClient(apiUrl);
            var request = new RestRequest(apiUrl, Method.Get);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                var profile = JsonSerializer.Deserialize<ProfileDTO>(response.Content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return profile;
            }
            else
            {
                MessageBox.Show($"Lỗi: {response.StatusCode} - {response.ErrorMessage}");
                return null;
            }
        }

        // Hàm gọi API để cập nhật thông tin Profile
        private async Task<bool> UpdateProfileAsync(UpdateProfile updatedProfile, int userId)
        {
            string apiUrl = $"https://localhost:7025/api/user/update-profile/{userId}";
            var client = new RestClient(apiUrl);
            var request = new RestRequest(apiUrl, Method.Put);

            // Chuyển đổi đối tượng `UpdateProfile` thành JSON
            string jsonBody = JsonSerializer.Serialize(updatedProfile);
            request.AddJsonBody(jsonBody);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Lỗi: {response.StatusCode} - {response.ErrorMessage}");
                return false;
            }
        }

        // Xử lý sự kiện Load của Form
        private async void EditProfileForm_Load(object sender, EventArgs e)
        {
            int userId = 1; // ID người dùng, có thể thay đổi
            var profile = await GetProfileAsync(userId);

            if (profile != null)
            {
                txtFirstName.Text = profile.FirstName;
                txtLastName.Text = profile.LastName;
                txtAddress.Text = profile.Address;
                txtCity.Text = profile.City;
                txtCountry.Text = profile.Country;
                txtPhone.Text = profile.Phone;
                txtAbout.Text = profile.AboutMe;

                nudCode.Minimum = 0;
                nudCode.Maximum = 999999;
                if (profile.PostalCode.HasValue)
                {
                    nudCode.Value = profile.PostalCode.Value;
                }

                if (!string.IsNullOrEmpty(profile.Avatar))
                {
                    try
                    {
                        var avatarImage = Image.FromFile(profile.Avatar);
                        picAvt.Image = avatarImage;
                    }
                    catch
                    {
                        MessageBox.Show("Không thể tải ảnh Avatar.");
                    }
                }

                if (profile.Birthday.HasValue)
                {
                    dtpBirthday.MinDate = new DateTime(1900, 1, 1);
                    dtpBirthday.MaxDate = DateTime.Today;

                    DateTime birthday = profile.Birthday.Value;
                    if (birthday >= dtpBirthday.MinDate && birthday <= dtpBirthday.MaxDate)
                    {
                        dtpBirthday.Value = birthday.Date;
                    }
                    else
                    {
                        MessageBox.Show($"Ngày sinh {birthday.ToShortDateString()} nằm ngoài phạm vi cho phép.");
                        dtpBirthday.Value = DateTime.Today;
                    }
                }
                else
                {
                    dtpBirthday.Value = DateTime.Today;
                }
            }
        }

        // Đóng form khi nhấn Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lưu thông tin và gọi API Update Profile
        private async void btnSave_Click(object sender, EventArgs e)
        {
            int userId = 1; // ID người dùng cần cập nhật

            // Tạo đối tượng `UpdateProfile` từ dữ liệu trên form
            var updatedProfile = new UpdateProfile
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                PostalCode = (int)nudCode.Value,
                AboutMe = txtAbout.Text,
                Avatar = null, // Thay đổi nếu cần lưu đường dẫn Avatar
                Phone = txtPhone.Text,
                Birthday = dtpBirthday.Value
            };

            // Gọi API cập nhật
            bool isSuccess = await UpdateProfileAsync(updatedProfile, userId);
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm b = new HomeForm();
            this.Close();
        }
    }
}
