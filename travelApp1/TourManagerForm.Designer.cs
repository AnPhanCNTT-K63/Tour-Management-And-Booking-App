namespace travelApp1
{
    partial class TourManagerForm
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
            toursDataGridView = new DataGridView();
            dataGridViewID = new DataGridViewTextBoxColumn();
            dataGridViewName = new DataGridViewTextBoxColumn();
            dataGridViewPrice = new DataGridViewTextBoxColumn();
            dataGridViewDuration = new DataGridViewTextBoxColumn();
            dataGridViewDescription = new DataGridViewTextBoxColumn();
            lblID = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtNameOfTour = new TextBox();
            textPrice = new TextBox();
            lblPrice = new Label();
            pictureBox1 = new PictureBox();
            btnChangePic = new Button();
            label2 = new Label();
            txtDuration = new TextBox();
            label3 = new Label();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)toursDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toursDataGridView
            // 
            toursDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toursDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewID, dataGridViewName, dataGridViewPrice, dataGridViewDuration, dataGridViewDescription });
            toursDataGridView.Location = new Point(12, 237);
            toursDataGridView.Name = "toursDataGridView";
            toursDataGridView.RowHeadersWidth = 51;
            toursDataGridView.Size = new Size(776, 201);
            toursDataGridView.TabIndex = 0;
            // 
            // dataGridViewID
            // 
            dataGridViewID.HeaderText = "ID";
            dataGridViewID.MinimumWidth = 6;
            dataGridViewID.Name = "dataGridViewID";
            dataGridViewID.Width = 125;
            // 
            // dataGridViewName
            // 
            dataGridViewName.HeaderText = "Tour Name";
            dataGridViewName.MinimumWidth = 6;
            dataGridViewName.Name = "dataGridViewName";
            dataGridViewName.Width = 125;
            // 
            // dataGridViewPrice
            // 
            dataGridViewPrice.HeaderText = "Price";
            dataGridViewPrice.MinimumWidth = 6;
            dataGridViewPrice.Name = "dataGridViewPrice";
            dataGridViewPrice.Width = 125;
            // 
            // dataGridViewDuration
            // 
            dataGridViewDuration.HeaderText = "Duration";
            dataGridViewDuration.MinimumWidth = 6;
            dataGridViewDuration.Name = "dataGridViewDuration";
            dataGridViewDuration.Width = 125;
            // 
            // dataGridViewDescription
            // 
            dataGridViewDescription.HeaderText = "Description";
            dataGridViewDescription.MinimumWidth = 6;
            dataGridViewDescription.Name = "dataGridViewDescription";
            dataGridViewDescription.Width = 125;
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
            // txtNameOfTour
            // 
            txtNameOfTour.Location = new Point(141, 50);
            txtNameOfTour.Name = "txtNameOfTour";
            txtNameOfTour.Size = new Size(125, 27);
            txtNameOfTour.TabIndex = 4;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(141, 102);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(125, 27);
            textPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 109);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(536, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 175);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnChangePic
            // 
            btnChangePic.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnChangePic.Location = new Point(595, 193);
            btnChangePic.Name = "btnChangePic";
            btnChangePic.Size = new Size(132, 29);
            btnChangePic.TabIndex = 8;
            btnChangePic.Text = "change picture";
            btnChangePic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 157);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Duration";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(141, 150);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(125, 27);
            txtDuration.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 12);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 11;
            label3.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(315, 57);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(190, 120);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(172, 193);
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
            btnDelete.Location = new Point(315, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // TourManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtDuration);
            Controls.Add(label2);
            Controls.Add(btnChangePic);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrice);
            Controls.Add(textPrice);
            Controls.Add(txtNameOfTour);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(toursDataGridView);
            Name = "TourManagerForm";
            Text = "TourManagerForm";
            ((System.ComponentModel.ISupportInitialize)toursDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView toursDataGridView;
        private DataGridViewTextBoxColumn dataGridViewID;
        private DataGridViewTextBoxColumn dataGridViewName;
        private DataGridViewTextBoxColumn dataGridViewPrice;
        private DataGridViewTextBoxColumn dataGridViewDuration;
        private DataGridViewTextBoxColumn dataGridViewDescription;
        private Label lblID;
        private TextBox txtID;
        private Label label1;
        private TextBox txtNameOfTour;
        private TextBox textPrice;
        private Label lblPrice;
        private PictureBox pictureBox1;
        private Button btnChangePic;
        private Label label2;
        private TextBox txtDuration;
        private Label label3;
        private RichTextBox txtDescription;
        private Button btnSave;
        private Button btnDelete;
    }
}