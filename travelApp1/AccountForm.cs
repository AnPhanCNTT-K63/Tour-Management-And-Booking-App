using System;
using System.Windows.Forms;

namespace travelApp1
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {

            InitializeComponent();


        }
        // Event handler for Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // You can add logic to save user details here
            MessageBox.Show("Changes Saved!");
        }

        // Event handler for Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Logic for Cancel button (close the form or reset fields)
            this.Close();
        }

        // Declare the controls
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private PictureBox avatarPictureBox;
        private Button btnSave;
        private Button btnCancel;
    }
}
