namespace travelApp1.PageForm
{
    partial class TourDetail
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
            lblName = new Label();
            lblCountry = new Label();
            lblRegion = new Label();
            lblCity = new Label();
            pictureBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(168, 72);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(168, 124);
            lblCountry.Margin = new Padding(4, 0, 4, 0);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(59, 25);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "label1";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(168, 184);
            lblRegion.Margin = new Padding(4, 0, 4, 0);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(59, 25);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "label1";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(168, 240);
            lblCity.Margin = new Padding(4, 0, 4, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(59, 25);
            lblCity.TabIndex = 3;
            lblCity.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(168, 319);
            pictureBox.Margin = new Padding(4, 4, 4, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(156, 78);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(358, 31);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(924, 624);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(168, 500);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 49);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // TourDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 1025);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox);
            Controls.Add(lblCity);
            Controls.Add(lblRegion);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TourDetail";
            Text = "TourDetail";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCountry;
        private Label lblRegion;
        private Label lblCity;
        private PictureBox pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBack;
    }
}