using System;
using System.Windows.Forms;

namespace travelApp1
{
    partial class SignUp : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbSignUp = new Label();
            lbUserName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Font = new Font("Times New Roman", 34.2F, FontStyle.Bold);
            lbSignUp.Location = new Point(150, 40);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(223, 65);
            lbSignUp.TabIndex = 0;
            lbSignUp.Text = "Sign Up";
            lbSignUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F);
            lbUserName.Location = new Point(70, 130);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(114, 23);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "User Name:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 12F);
            lbEmail.Location = new Point(70, 180);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(64, 23);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Arial", 12F);
            lbPassword.Location = new Point(70, 230);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(104, 23);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(200, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Font = new Font("Times New Roman", 13.8F);
            btnSignUp.Location = new Point(200, 280);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(126, 38);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // SignUp
            // 
            ClientSize = new Size(500, 400);
            Controls.Add(lbSignUp);
            Controls.Add(lbUserName);
            Controls.Add(lbEmail);
            Controls.Add(lbPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(btnSignUp);
            Name = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lbSignUp;
        private Label lbUserName;
        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignUp;
    }
}
