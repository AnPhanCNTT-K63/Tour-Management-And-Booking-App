namespace travelApp1
{
    partial class ProfileForm
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
            lblProfile = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblProfile.Location = new Point(254, 9);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(242, 29);
            lblProfile.TabIndex = 9;
            lblProfile.Text = "Profile Management";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 12F);
            lblName.Location = new Point(23, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 12F);
            lblEmail.Location = new Point(26, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial", 12F);
            lblPhone.Location = new Point(26, 191);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 23);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 12F);
            btnSave.Location = new Point(152, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial", 12F);
            btnCancel.Location = new Point(305, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(626, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 105);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 72);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 11;
            label1.Text = "name";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblProfile);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfile;
        private PictureBox pictureBox1;
        private Label label1;
    }
}