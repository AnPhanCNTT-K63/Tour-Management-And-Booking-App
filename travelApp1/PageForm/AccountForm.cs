using RestSharp;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.PageForm;

namespace travelApp1
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            this.Load += AccountForm_Load; // Đăng ký sự kiện Load
        }

        // Hàm gọi API để lấy dữ liệu tài khoản
        private async Task<AccountDTO> GetAccountAsync(int userId)
        {
            string apiUrl = $"https://localhost:7025/api/user/{userId}/account";
            var client = new RestClient(apiUrl);
            var request = new RestRequest(apiUrl, Method.Get);

            // Gửi request
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                // Deserialize JSON thành AccountDTO
                var account = JsonSerializer.Deserialize<AccountDTO>(response.Content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return account;
            }
            else
            {
                MessageBox.Show($"Lỗi: {response.StatusCode} - {response.ErrorMessage}");
                return null;
            }
        }

        // Hàm gọi API để cập nhật thông tin tài khoản
        private async Task<bool> UpdateAccountAsync(int userId, AccountDTO updatedAccount)
        {
            string apiUrl = $"https://localhost:7025/api/user/{userId}/account";
            var client = new RestClient(apiUrl);
            var request = new RestRequest(apiUrl, Method.Put);

            // Serialize đối tượng thành JSON
            string jsonBody = JsonSerializer.Serialize(updatedAccount);
            request.AddStringBody(jsonBody, ContentType.Json);

            // Gửi request
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Lỗi cập nhật: {response.StatusCode} - {response.ErrorMessage}");
                return false;
            }
        }

        // Xử lý sự kiện Load của Form
        private async void AccountForm_Load(object sender, EventArgs e)
        {
            int userId = 1014; 
            var account = await GetAccountAsync(userId);

            if (account != null)
            {
                txtUsername.Text = account.Username;
                txtEmail.Text = account.Email;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm h = new HomeForm();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAccountForm editForm = new EditAccountForm();
            editForm.ShowDialog();
        }
    }
}
