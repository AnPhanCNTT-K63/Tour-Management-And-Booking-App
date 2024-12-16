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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            emailLabel = new Label();
            phoneLabel = new Label();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            avatarPictureBox = new PictureBox();
            changeAvatarButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(135, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(140, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(333, 26);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(430, 23);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 27);
            txtLastName.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(20, 169);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(49, 20);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(20, 220);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(53, 20);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Phone:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(135, 166);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(235, 27);
            emailTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(135, 217);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(235, 27);
            phoneTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(135, 326);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(82, 50);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(286, 326);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(84, 50);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.BackColor = Color.Gray;
            avatarPictureBox.Location = new Point(660, 20);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(100, 100);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 8;
            avatarPictureBox.TabStop = false;
            // 
            // changeAvatarButton
            // 
            changeAvatarButton.Location = new Point(660, 139);
            changeAvatarButton.Name = "changeAvatarButton";
            changeAvatarButton.Size = new Size(100, 50);
            changeAvatarButton.TabIndex = 9;
            changeAvatarButton.Text = "Change Avatar";
            changeAvatarButton.UseVisualStyleBackColor = true;
            changeAvatarButton.Click += ChangeAvatarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 120);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 10;
            label1.Text = "City:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 13;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 123);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 14;
            label3.Text = "Country";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 220);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Introduce:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(467, 256);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(323, 120);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 274);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 19;
            label6.Text = "Postal Code";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 271);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 27);
            textBox4.TabIndex = 20;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 488);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(changeAvatarButton);
            Controls.Add(avatarPictureBox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Name = "ProfileForm";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label6;
        private TextBox textBox4;
    }
}