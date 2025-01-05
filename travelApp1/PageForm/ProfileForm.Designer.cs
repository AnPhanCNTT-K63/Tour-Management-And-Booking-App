namespace travelApp1.PageForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblPhone = new Label();
            lblName = new Label();
            lblProfile = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCity = new TextBox();
            txtPhone = new TextBox();
            txtCountry = new TextBox();
            txtAddress = new TextBox();
            txtAbout = new TextBox();
            dtpBirthday = new DateTimePicker();
            nudCode = new NumericUpDown();
            btnHome = new Button();
            btnChangeImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(698, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 138);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial", 12F);
            btnCancel.Location = new Point(543, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 12F);
            btnSave.Location = new Point(282, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial", 12F);
            lblPhone.Location = new Point(72, 146);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 23);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 12F);
            lblName.Location = new Point(72, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 12;
            lblName.Text = "FirstName";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblProfile.Location = new Point(350, 9);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(88, 29);
            lblProfile.TabIndex = 17;
            lblProfile.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 207);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 20;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(405, 76);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 21;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(405, 146);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 22;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(405, 206);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 23;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(405, 271);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 24;
            label6.Text = "Postal Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(72, 272);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 25;
            label7.Text = "About me";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(72, 346);
            label8.Name = "label8";
            label8.Size = new Size(82, 23);
            label8.TabIndex = 26;
            label8.Text = "Birthday";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(197, 73);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 27);
            txtFirstName.TabIndex = 27;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(523, 73);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 27);
            txtLastName.TabIndex = 28;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(523, 142);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(121, 27);
            txtCity.TabIndex = 30;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(197, 144);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(121, 27);
            txtPhone.TabIndex = 31;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(523, 204);
            txtCountry.Margin = new Padding(2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(121, 27);
            txtCountry.TabIndex = 32;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(197, 207);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(121, 27);
            txtAddress.TabIndex = 33;
            // 
            // txtAbout
            // 
            txtAbout.Location = new Point(197, 268);
            txtAbout.Margin = new Padding(2);
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(121, 27);
            txtAbout.TabIndex = 35;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(197, 342);
            dtpBirthday.Margin = new Padding(2);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(241, 27);
            dtpBirthday.TabIndex = 37;
            // 
            // nudCode
            // 
            nudCode.Location = new Point(525, 269);
            nudCode.Margin = new Padding(2);
            nudCode.Name = "nudCode";
            nudCode.Size = new Size(144, 27);
            nudCode.TabIndex = 38;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Arial", 12F);
            btnHome.Location = new Point(90, 412);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 40);
            btnHome.TabIndex = 39;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnChangeImage
            // 
            btnChangeImage.Location = new Point(720, 184);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Size = new Size(130, 29);
            btnChangeImage.TabIndex = 40;
            btnChangeImage.Text = "Change Image";
            btnChangeImage.UseVisualStyleBackColor = true;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 484);
            Controls.Add(btnChangeImage);
            Controls.Add(btnHome);
            Controls.Add(nudCode);
            Controls.Add(dtpBirthday);
            Controls.Add(txtAbout);
            Controls.Add(txtAddress);
            Controls.Add(txtCountry);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(lblProfile);
            Margin = new Padding(2);
            Name = "ProfileForm";
            Text = "EditProfileForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private Button btnSave;
        private Label lblPhone;
        private Label lblName;
        private Label lblProfile;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCity;
        private TextBox txtPhone;
        private TextBox txtCountry;
        private TextBox txtAddress;
        private TextBox txtAbout;
        private DateTimePicker dtpBirthday;
        private NumericUpDown nudCode;
        private Button btnHome;
        private Button btnChangeImage;
    }
}