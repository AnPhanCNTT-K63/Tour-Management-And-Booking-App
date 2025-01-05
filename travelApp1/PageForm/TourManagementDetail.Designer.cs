namespace travelApp1
{
    partial class TourManagementDetail
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
            lblID = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtTourName = new TextBox();
            pictureBox1 = new PictureBox();
            btnChangePic = new Button();
            label2 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txtCountry = new TextBox();
            label5 = new Label();
            txtRegion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtOpening = new TextBox();
            txtEnding = new TextBox();
            txtCreatedAt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtUserId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 12);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(141, 5);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 3;
            label1.Text = "Name of tour:";
            // 
            // txtTourName
            // 
            txtTourName.Location = new Point(141, 50);
            txtTourName.Name = "txtTourName";
            txtTourName.Size = new Size(125, 27);
            txtTourName.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(815, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 175);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnChangePic
            // 
            btnChangePic.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnChangePic.Location = new Point(877, 193);
            btnChangePic.Name = "btnChangePic";
            btnChangePic.Size = new Size(132, 29);
            btnChangePic.TabIndex = 8;
            btnChangePic.Text = "change picture";
            btnChangePic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 9;
            label2.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(141, 95);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 57);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 11;
            label3.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(619, 90);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(190, 79);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(248, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(462, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 377);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1055, 386);
            dataGridView1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 50);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 16;
            label4.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(402, 46);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 102);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 18;
            label5.Text = "Region:";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(402, 95);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(125, 27);
            txtRegion.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 142);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 20;
            label6.Text = "Opening:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 193);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 21;
            label7.Text = "Ending:";
            // 
            // txtOpening
            // 
            txtOpening.Location = new Point(141, 142);
            txtOpening.Name = "txtOpening";
            txtOpening.Size = new Size(125, 27);
            txtOpening.TabIndex = 22;
            // 
            // txtEnding
            // 
            txtEnding.Location = new Point(141, 194);
            txtEnding.Name = "txtEnding";
            txtEnding.Size = new Size(125, 27);
            txtEnding.TabIndex = 23;
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.Location = new Point(402, 142);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.Size = new Size(125, 27);
            txtCreatedAt.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 149);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 25;
            label8.Text = "Created At";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 12);
            label9.Name = "label9";
            label9.Size = new Size(161, 20);
            label9.TabIndex = 26;
            label9.Text = "Created By (Admin ID):";
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Location = new Point(476, 8);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(125, 27);
            txtUserId.TabIndex = 27;
            // 
            // TourManagementDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 797);
            Controls.Add(txtUserId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtCreatedAt);
            Controls.Add(txtEnding);
            Controls.Add(txtOpening);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRegion);
            Controls.Add(label5);
            Controls.Add(txtCountry);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(btnChangePic);
            Controls.Add(pictureBox1);
            Controls.Add(txtTourName);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "TourManagementDetail";
            Text = "TourManagerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private TextBox txtID;
        private Label label1;
        private TextBox txtTourName;
        private PictureBox pictureBox1;
        private Button btnChangePic;
        private Label label2;
        private TextBox txtCity;
        private Label label3;
        private RichTextBox txtDescription;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtCountry;
        private Label label5;
        private TextBox txtRegion;
        private Label label6;
        private Label label7;
        private TextBox txtOpening;
        private TextBox txtEnding;
        private TextBox txtCreatedAt;
        private Label label8;
        private Label label9;
        private TextBox txtUserId;
    }
}