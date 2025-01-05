using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class EditAccountForm : Form
    {
        private readonly ApiService _apiService;
        private readonly AccountDTO _account;
        private readonly string _editType; // Field to determine what is being edited (username, email, or password)

        public EditAccountForm(AccountDTO account, string editType)
        {
            InitializeComponent();
            _apiService = new ApiService();
            _account = account;
            _editType = editType;

            InitializeForm(); // Initialize form UI based on the edit type
        }

        private void InitializeForm()
        {
            lblTitle.Text = $"Thay đổi {_editType}";
            txtCurrentValue.Text = _editType == "password" ? "********" : GetCurrentFieldValue();
            txtCurrentValue.ReadOnly = true;
            txtNewValue.PlaceholderText = $"Nhập {_editType} mới";
            txtPassword.PlaceholderText = "Nhập mật khẩu hiện tại";
        }

        private string GetCurrentFieldValue()
        {
            return _editType switch
            {
                "username" => _account.Username,
                "email" => _account.Email,
                _ => string.Empty
            };
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            string newValue = txtNewValue.Text.Trim();
            string currentPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(newValue))
            {
                MessageBox.Show($"Vui lòng nhập {_editType} mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(currentPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an instance of UpdateAccountDTO based on the edit type
            var updateRequest = new UpdateAccountDTO
            {
                Password = currentPassword // Current password is always required
            };

            switch (_editType)
            {
                case "username":
                    updateRequest.Username = newValue;
                    break;
                case "email":
                    updateRequest.Email = newValue;
                    break;
                case "password":
                    updateRequest.NewPassword = newValue;
                    break;
                default:
                    MessageBox.Show("Loại chỉnh sửa không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            var isSuccess = await UpdateAccountAsync(updateRequest, int.Parse(UserIndentity.Id));

            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task<bool> UpdateAccountAsync(UpdateAccountDTO request, int userId)
        {
            try
            {
                string apiUrl = $"user/update-account/{userId}";
                var response = await _apiService.PutAsync(apiUrl, request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Lỗi cập nhật tài khoản: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật tài khoản: {ex.Message}");
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
