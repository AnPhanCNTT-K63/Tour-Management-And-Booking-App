namespace travelApp1.PageForm
{
    partial class EditAccountForm
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
            btnCancel = new Button();
            btnSave = new Button();
            txtNewPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(459, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 41);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(153, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 41);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(253, 289);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(187, 31);
            txtNewPassword.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(253, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 31);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(253, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 31);
            txtEmail.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(253, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 31);
            txtUsername.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 217);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 289);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 14;
            label4.Text = "NewPassword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 145);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 27);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 11;
            label1.Text = "Account Management";
            // 
            // EditAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNewPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditAccountForm";
            Text = "EditAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtNewPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}