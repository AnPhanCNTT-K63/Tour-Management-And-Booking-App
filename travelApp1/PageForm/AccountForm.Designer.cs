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
            btnEdit = new Button();
            btnCancel = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 26);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 127);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 231);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(293, 121);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(279, 31);
            txtUsername.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 31);
            txtEmail.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(283, 359);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 41);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(504, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 41);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(72, 359);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(112, 41);
            btnHome.TabIndex = 11;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHome);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Button btnEdit;
        private Button btnCancel;
        private Button btnHome;
    }
}