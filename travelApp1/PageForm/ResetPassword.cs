using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class ResetPassword : Form
    {
        private readonly ApiService _apiService;
        private readonly string _email;
        public ResetPassword(string email)
        {
            InitializeComponent();
            _apiService = new ApiService();
            _email = email;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            var newPassword = txbPassword.Text.Trim();
            var code = txbCode.Text.Trim();

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var res = await _apiService.PostAsync("auth/reset-password", new { Email = _email, VerificationCode = code, NewPassword = newPassword });
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    var errorMessage = await res.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {errorMessage}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
