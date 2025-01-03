using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class ForgotPassword : Form
    {
        private readonly ApiService _apiService;
        public ForgotPassword()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void btnGetCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            try
            {
                var res = await _apiService.PostAsync("auth/forgot-password", new { to = email });
                if (res.IsSuccessStatusCode)
                {

                    MessageBox.Show("Code sent to your email!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var form = new ResetPassword(email);
                    form.Show();
                    this.Hide();
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
