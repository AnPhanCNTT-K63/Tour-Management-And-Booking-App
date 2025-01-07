using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using travelApp1.Services;

namespace travelApp1
{
    public partial class SignUp : Form
    {
        private readonly ApiService _apiService;

        public SignUp()
        {
            InitializeComponent();
            string imagePath = Path.Combine(Application.StartupPath, "Images", "BackgroundLogin.jpg");
            panelSignup.BackgroundImage = Image.FromFile(imagePath);
            panelSignup.BackgroundImageLayout = ImageLayout.Stretch; // Điều chỉnh hiển thị ảnh
            _apiService = new ApiService();
            txtPassword.PasswordChar = '*';
        }



        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private async void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var userData = new { Username = userName, Email = email, Password = password };
                var response = await _apiService.PostAsync("auth/register", userData);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var form = new Signin();
                    form.Show();
                    this.Close();
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {errorMessage}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Signin();
            form.Show();
            this.Close();
        }
    }
}
