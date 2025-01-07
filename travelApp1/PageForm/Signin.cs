using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.PageForm;
using travelApp1.Services;

namespace travelApp1
{
    public partial class Signin : Form
    {
        private readonly ApiService _apiService;

        public Signin()
        {
            InitializeComponent();

            panelSignin.BackgroundImageLayout = ImageLayout.Stretch; // Điều chỉnh hiển thị ảnh
            _apiService = new ApiService();
            txtPassword.PasswordChar = '*';
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var data = new { email = username, password = password };
                var response = await _apiService.PostAsync("auth/login", data);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();


                    string token = responseContent;

                    if (!string.IsNullOrEmpty(token))
                    {
                        Properties.Settings.Default.AccessToken = token;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Login successful, but token was not retrieved.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
                    {
                        var claims = JwtHelper.DecodeJwt(Properties.Settings.Default.AccessToken);

                        if (claims != null)
                        {
                            var claimsJson = JsonConvert.SerializeObject(claims, Formatting.Indented);
                            UserIndentity.Username = claims["unique_name"].ToString();
                            UserIndentity.Email = claims["email"].ToString();
                            UserIndentity.Role = claims["role"].ToString();
                            UserIndentity.Id = claims["nameid"].ToString();
                        }
                    }

                    if (UserIndentity.Role == "admin")
                    {
                        var form = new AdminForm();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        var form = new HomeForm();
                        form.Show();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Incorrect password or email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelFogotP_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ForgotPassword();
            form.Show();
            this.Hide();
        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new SignUp();
            form.Show();
            this.Hide();
        }
    }
}
