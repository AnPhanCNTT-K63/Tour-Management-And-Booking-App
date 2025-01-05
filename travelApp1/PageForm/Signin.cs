using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
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

            string imagePath = Path.Combine(Application.StartupPath, "Images", "BackgroundLogin.jpg");
            panelSignin.BackgroundImage = Image.FromFile(imagePath);
            panelSignin.BackgroundImageLayout = ImageLayout.Stretch; // Điều chỉnh hiển thị ảnh
            _apiService = new ApiService();
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
            MessageBox.Show("Redirecting to Forgot Password page...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var form = new ForgotPassword();
            form.Show();
            this.Hide();
        }
    }
}
