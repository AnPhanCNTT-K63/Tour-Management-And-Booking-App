using System;
using System.Windows.Forms;

namespace travelApp1
{
    partial class Signin : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbSignIn = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            linkLabelFogotP = new LinkLabel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbSignIn
            // 
            lbSignIn.AutoSize = true;
            lbSignIn.Font = new Font("Times New Roman", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignIn.Location = new Point(266, 66);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(203, 65);
            lbSignIn.TabIndex = 0;
            lbSignIn.Text = "Sign In";
            lbSignIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Times New Roman", 14F);
            lbUsername.Location = new Point(48, 23);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(68, 27);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(54, 80);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(102, 26);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(204, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(262, 34);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(205, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 34);
            txtPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(278, 316);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 6;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // linkLabelFogotP
            // 
            linkLabelFogotP.AutoSize = true;
            linkLabelFogotP.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelFogotP.LinkColor = Color.MidnightBlue;
            linkLabelFogotP.Location = new Point(364, 269);
            linkLabelFogotP.Name = "linkLabelFogotP";
            linkLabelFogotP.Size = new Size(145, 22);
            linkLabelFogotP.TabIndex = 7;
            linkLabelFogotP.TabStop = true;
            linkLabelFogotP.Text = "Forgot Password";
            linkLabelFogotP.LinkClicked += linkLabelFogotP_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(108, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 129);
            panel1.TabIndex = 8;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(linkLabelFogotP);
            Controls.Add(button1);
            Controls.Add(lbSignIn);
            Name = "Signin";
            Text = "Signin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lbSignIn;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private LinkLabel linkLabelFogotP;
        private Panel panel1;
    }
}
