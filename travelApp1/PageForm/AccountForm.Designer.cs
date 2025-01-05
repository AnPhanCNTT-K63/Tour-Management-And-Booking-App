namespace travelApp1
{
    partial class AccountForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnEditUsername = new Button();
            btnCancel = new Button();
            btnHome = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            btnEditEmail = new Button();
            btnEditPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Account Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.No;
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(234, 74);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.No;
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(234, 130);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 6;
            // 
            // btnEditUsername
            // 
            btnEditUsername.Location = new Point(480, 71);
            btnEditUsername.Margin = new Padding(2);
            btnEditUsername.Name = "btnEditUsername";
            btnEditUsername.Size = new Size(131, 33);
            btnEditUsername.TabIndex = 9;
            btnEditUsername.Text = "Edit Username";
            btnEditUsername.UseVisualStyleBackColor = true;
            btnEditUsername.Click += btnEditUsername_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(403, 287);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 33);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(58, 287);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(90, 33);
            btnHome.TabIndex = 11;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 184);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.No;
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(234, 184);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 27);
            txtPassword.TabIndex = 13;
            // 
            // btnEditEmail
            // 
            btnEditEmail.Location = new Point(480, 124);
            btnEditEmail.Margin = new Padding(2);
            btnEditEmail.Name = "btnEditEmail";
            btnEditEmail.Size = new Size(131, 33);
            btnEditEmail.TabIndex = 14;
            btnEditEmail.Text = "Edit Email";
            btnEditEmail.UseVisualStyleBackColor = true;
            btnEditEmail.Click += btnEditEmail_Click;
            // 
            // btnEditPassword
            // 
            btnEditPassword.Location = new Point(480, 178);
            btnEditPassword.Margin = new Padding(2);
            btnEditPassword.Name = "btnEditPassword";
            btnEditPassword.Size = new Size(131, 33);
            btnEditPassword.TabIndex = 15;
            btnEditPassword.Text = "Edit Password";
            btnEditPassword.UseVisualStyleBackColor = true;
            btnEditPassword.Click += btnEditPassword_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnEditPassword);
            Controls.Add(btnEditEmail);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(btnHome);
            Controls.Add(btnCancel);
            Controls.Add(btnEditUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AccountForm";
            Text = "AccoutnForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Button btnEditUsername;
        private Button btnCancel;
        private Button btnHome;
        private Label label6;
        private TextBox txtPassword;
        private Button btnEditEmail;
        private Button btnEditPassword;
    }
}