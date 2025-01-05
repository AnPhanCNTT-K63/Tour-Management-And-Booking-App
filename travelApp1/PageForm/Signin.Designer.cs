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
            panelSignin = new Panel();
            panel1 = new Panel();
            lbUsername = new Label();
            txtUsername = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            linkLabelFogotP = new LinkLabel();
            button1 = new Button();
            lbSignIn = new Label();
            panelSignin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSignin
            // 
            panelSignin.Controls.Add(panel1);
            panelSignin.Controls.Add(linkLabelFogotP);
            panelSignin.Controls.Add(button1);
            panelSignin.Controls.Add(lbSignIn);
            panelSignin.Location = new Point(12, 2);
            panelSignin.Name = "panelSignin";
            panelSignin.Size = new Size(787, 436);
            panelSignin.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(134, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 129);
            panel1.TabIndex = 12;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = Color.LightGray;
            lbUsername.Font = new Font("Times New Roman", 14F);
            lbUsername.Location = new Point(54, 19);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(68, 27);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(204, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(262, 34);
            txtUsername.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.LightGray;
            lbPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(54, 80);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(102, 26);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(205, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 34);
            txtPassword.TabIndex = 4;
            // 
            // linkLabelFogotP
            // 
            linkLabelFogotP.AutoSize = true;
            linkLabelFogotP.BackColor = Color.Transparent;
            linkLabelFogotP.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelFogotP.LinkColor = Color.MidnightBlue;
            linkLabelFogotP.Location = new Point(390, 273);
            linkLabelFogotP.Name = "linkLabelFogotP";
            linkLabelFogotP.Size = new Size(145, 22);
            linkLabelFogotP.TabIndex = 11;
            linkLabelFogotP.TabStop = true;
            linkLabelFogotP.Text = "Forgot Password";
            linkLabelFogotP.LinkClicked += linkLabelFogotP_LinkClicked_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(304, 320);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 10;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbSignIn
            // 
            lbSignIn.AutoSize = true;
            lbSignIn.BackColor = Color.Transparent;
            lbSignIn.FlatStyle = FlatStyle.Flat;
            lbSignIn.Font = new Font("Times New Roman", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignIn.Location = new Point(292, 70);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(203, 65);
            lbSignIn.TabIndex = 9;
            lbSignIn.Text = "Sign In";
            lbSignIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelSignin);
            Name = "Signin";
            Text = "Signin";
            panelSignin.ResumeLayout(false);
            panelSignin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSignin;
        private Panel panel1;
        private Label lbUsername;
        private TextBox txtUsername;
        private Label lbPassword;
        private TextBox txtPassword;
        private LinkLabel linkLabelFogotP;
        private Button button1;
        private Label lbSignIn;
    }
}
