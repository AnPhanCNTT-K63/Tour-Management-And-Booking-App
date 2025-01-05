using Newtonsoft.Json;
using RestSharp;
using System;
using System.Drawing;
using System.IO.Packaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class ProfileForm : Form
    {
        private readonly ApiService _apiService;
        private string uploadedAvatarName = null;
        private string currentAvatarName = null;

        public ProfileForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
            this.Load += EditProfileForm_Load;
        }

        private async Task<ProfileDTO> GetProfileAsync(int userId)
        {
            string apiUrl = $"user/{userId}/profile";
            var response = await _apiService.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var profileJson = await response.Content.ReadAsStringAsync();
                var profile = JsonConvert.DeserializeObject<ProfileDTO>(profileJson);
                return profile;
            }
            else
            {
                MessageBox.Show($"Lỗi: {response.StatusCode} - {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Hàm gọi API để cập nhật thông tin Profile
        private async Task<bool> UpdateProfileAsync(UpdateProfile updatedProfile, int userId)
        {
            string apiUrl = $"user/update-profile/{userId}";
            var response = await _apiService.PutAsync(apiUrl, updatedProfile);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Lỗi: {response.StatusCode} - {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Xử lý sự kiện Load của Form
        private async void EditProfileForm_Load(object sender, EventArgs e)
        {
            var profile = await GetProfileAsync(int.Parse(UserIndentity.Id));

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
                nudCode.Value = profile.PostalCode ?? 0;

                if (!string.IsNullOrEmpty(profile.Avatar))
                {
                    currentAvatarName = profile.Avatar; // Store the current avatar name
                    try
                    {
                        Image avatar = await LoadImageFromUrl($"{CloudHelper.CloudUri}/Avatars/{profile.Avatar}");
                        pictureBox1.Image = avatar;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        MessageBox.Show("Không thể tải ảnh Avatar.");
                    }
                }

                dtpBirthday.MinDate = new DateTime(1900, 1, 1);
                dtpBirthday.MaxDate = DateTime.Today;

                // Check if Birthday is valid
                if (profile.Birthday.HasValue && profile.Birthday.Value >= dtpBirthday.MinDate && profile.Birthday.Value <= dtpBirthday.MaxDate)
                {
                    dtpBirthday.Value = profile.Birthday.Value;
                }
                else
                {
                    dtpBirthday.Value = DateTime.Today; // Set to today's date if invalid
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


        // Đóng form khi nhấn Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lưu thông tin và gọi API Update Profile
        private async void btnSave_Click(object sender, EventArgs e)
        {

            var updatedProfile = new UpdateProfile
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                PostalCode = (int)nudCode.Value,
                AboutMe = txtAbout.Text,
                Avatar = uploadedAvatarName ?? currentAvatarName, // Use the uploaded avatar name if available
                Phone = txtPhone.Text,
                Birthday = dtpBirthday.Value
            };

            bool isSuccess = await UpdateProfileAsync(updatedProfile, int.Parse(UserIndentity.Id));
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm b = new HomeForm();
            this.Close();
        }

        private async void btnChangeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    // Upload the selected image
                    uploadedAvatarName = await UploadImageAsync(selectedImagePath, "Avatars");

                    if (!string.IsNullOrEmpty(uploadedAvatarName))
                    {
                        MessageBox.Show("Ảnh đại diện đã được thay đổi thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải lên ảnh đại diện.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async Task<string> UploadImageAsync(string imagePath, string folder)
        {
            using (var client = new RestClient("https://localhost:7025/api/"))
            {
                var request = new RestRequest("cloud/upload", Method.Post);
                request.AddFile("file", imagePath);
                request.AddParameter("folder", folder);

                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    // Assuming the API returns the uploaded file's URL or name
                    string uploadedImageUrl = response.Content.Trim('"');
                    string imageName = Path.GetFileName(uploadedImageUrl); // Extract only the image name
                    return imageName;
                }
                else
                {
                    MessageBox.Show($"Failed to upload image: {response.StatusCode} - {response.ErrorMessage}", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }



    }
}
