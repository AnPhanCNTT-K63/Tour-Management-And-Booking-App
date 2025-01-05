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
            panelSignup = new Panel();
            lbSignUp = new Label();
            lbUserName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            panelSignup.SuspendLayout();
            SuspendLayout();
            // 
            // panelSignup
            // 
            panelSignup.Controls.Add(lbSignUp);
            panelSignup.Controls.Add(lbUserName);
            panelSignup.Controls.Add(lbEmail);
            panelSignup.Controls.Add(lbPassword);
            panelSignup.Controls.Add(txtUserName);
            panelSignup.Controls.Add(txtEmail);
            panelSignup.Controls.Add(txtPassword);
            panelSignup.Controls.Add(btnSignUp);
            panelSignup.Location = new Point(3, 3);
            panelSignup.Name = "panelSignup";
            panelSignup.Size = new Size(498, 401);
            panelSignup.TabIndex = 0;
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.BackColor = Color.Transparent;
            lbSignUp.Font = new Font("Times New Roman", 34.2F, FontStyle.Bold);
            lbSignUp.Location = new Point(164, 61);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(223, 65);
            lbSignUp.TabIndex = 8;
            lbSignUp.Text = "Sign Up";
            lbSignUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial", 12F);
            lbUserName.Location = new Point(84, 151);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(114, 23);
            lbUserName.TabIndex = 9;
            lbUserName.Text = "User Name:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 12F);
            lbEmail.Location = new Point(84, 201);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(64, 23);
            lbEmail.TabIndex = 10;
            lbEmail.Text = "Email:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Arial", 12F);
            lbPassword.Location = new Point(84, 251);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(104, 23);
            lbPassword.TabIndex = 11;
            lbPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(214, 151);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(214, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(214, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 14;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Font = new Font("Times New Roman", 13.8F);
            btnSignUp.Location = new Point(214, 301);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(126, 38);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            ClientSize = new Size(500, 400);
            Controls.Add(panelSignup);
            Name = "SignUp";
            panelSignup.ResumeLayout(false);
            panelSignup.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelSignup;
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
