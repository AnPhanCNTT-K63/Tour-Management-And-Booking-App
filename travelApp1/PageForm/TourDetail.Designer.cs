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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(134, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(134, 99);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 20);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "label1";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(134, 147);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(50, 20);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "label1";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(134, 192);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(50, 20);
            lblCity.TabIndex = 3;
            lblCity.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(134, 255);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(125, 62);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(286, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(739, 499);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // TourDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 820);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox);
            Controls.Add(lblCity);
            Controls.Add(lblRegion);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
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
    }
}