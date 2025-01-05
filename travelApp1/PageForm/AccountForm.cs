using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.PageForm;
using travelApp1.Services;

namespace travelApp1
{
    public partial class AccountForm : Form
    {
        private AccountDTO _account = new AccountDTO();
        private readonly ApiService apiService = new ApiService();
        public AccountForm()
        {
            InitializeComponent();
            this.Load += AccountForm_Load; // Đăng ký sự kiện Load
            txtPassword.Text = "********";

        }

        // Hàm gọi API để lấy dữ liệu tài khoản
        private async Task<AccountDTO> GetAccountAsync(int userId)
        {
            try
            {
                var res = await apiService.GetAsync($"user/{userId}/account");

                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var account = JsonConvert.DeserializeObject<AccountDTO>(json);

                    _account = account;

                    return account;
                }
                else
                {
                    MessageBox.Show($"Lỗi lấy thông tin tài khoản: {res.StatusCode} - {res.ReasonPhrase}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy thông tin tài khoản: {ex.Message}");
                return null;
            }
        }

        // Xử lý sự kiện Load của Form
        private async void AccountForm_Load(object sender, EventArgs e)
        {

            var account = await GetAccountAsync(int.Parse(UserIndentity.Id));

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

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            EditAccountForm editForm = new EditAccountForm(_account, "username");
            editForm.FormClosed += (s, args) => AccountForm_Load(null, null);
            editForm.ShowDialog();
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            EditAccountForm editForm = new EditAccountForm(_account, "email");
            editForm.FormClosed += (s, args) => AccountForm_Load(null, null);
            editForm.ShowDialog();
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            EditAccountForm editForm = new EditAccountForm(_account, "password");
            editForm.FormClosed += (s, args) => AccountForm_Load(null, null);
            editForm.ShowDialog();
        }
    }
}
