using RestSharp;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;

namespace travelApp1.PageForm
{
    public partial class EditAccountForm : Form
    {
        private int userId = 1014; // ID người dùng hiện tại

        public EditAccountForm()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra mật khẩu cũ
        private async Task<bool> CheckOldPasswordAsync(string oldPassword)
        {
            try
            {
                string apiUrl = "https://localhost:7025/api/auth/password-check";
                var client = new RestClient(apiUrl);
                var request = new RestRequest(apiUrl, Method.Post);

                // Gửi mật khẩu cũ qua body
                var requestBody = new { password = oldPassword, userId = userId };
                request.AddJsonBody(requestBody);

                // Log dữ liệu gửi lên
                Console.WriteLine("CheckOldPasswordAsync - Request:");
                Console.WriteLine(JsonSerializer.Serialize(requestBody));

                var response = await client.ExecuteAsync(request);

                // Log kết quả phản hồi
                Console.WriteLine("CheckOldPasswordAsync - Response:");
                Console.WriteLine($"StatusCode: {response.StatusCode}, Content: {response.Content}");

                if (response.IsSuccessful)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Mật khẩu cũ không đúng: {response.StatusCode} - {response.Content}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra mật khẩu: {ex.Message}");
                return false;
            }
        }

        // Hàm cập nhật thông tin tài khoản
        private async Task<bool> UpdateAccountAsync(AccountDTO updatedAccount, string oldPassword, string newPassword)
        {
            try
            {
                string apiUrl = $"https://localhost:7025/api/user/update-account/{userId}";
                var client = new RestClient(apiUrl);
                var request = new RestRequest(apiUrl, Method.Put);

                // Dữ liệu gửi lên API
                var requestBody = new
                {
                    email = updatedAccount.Email.Trim(),
                    username = updatedAccount.Username.Trim(),
                    newPassword = newPassword.Trim(),
                    password = oldPassword.Trim()
                };
                request.AddJsonBody(requestBody);

                // Log dữ liệu gửi lên
                Console.WriteLine("UpdateAccountAsync - Request:");
                Console.WriteLine(JsonSerializer.Serialize(requestBody));

                var response = await client.ExecuteAsync(request);

                // Log kết quả phản hồi
                Console.WriteLine("UpdateAccountAsync - Response:");
                Console.WriteLine($"StatusCode: {response.StatusCode}, Content: {response.Content}");

                if (response.IsSuccessful)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Lỗi cập nhật tài khoản: {response.StatusCode} - {response.Content}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tài khoản: {ex.Message}");
                return false;
            }
        }

        // Xử lý sự kiện khi nhấn nút Save
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = txtPassword.Text.Trim();
                string newPassword = txtNewPassword.Text.Trim();

                if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu cũ và mật khẩu mới.");
                    return;
                }

                // Kiểm tra mật khẩu cũ
                bool isPasswordCorrect = await CheckOldPasswordAsync(oldPassword);

                if (isPasswordCorrect)
                {
                    // Tạo đối tượng AccountDTO với dữ liệu mới
                    var updatedAccount = new AccountDTO
                    {
                        Username = txtUsername.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };

                    // Kiểm tra dữ liệu trước khi gửi lên API
                    if (string.IsNullOrEmpty(updatedAccount.Username) || string.IsNullOrEmpty(updatedAccount.Email))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.");
                        return;
                    }

                    // Gửi yêu cầu cập nhật tài khoản
                    bool isUpdated = await UpdateAccountAsync(updatedAccount, oldPassword, newPassword);

                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý: {ex.Message}");
            }
        }

        // Xử lý sự kiện khi nhấn nút Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
