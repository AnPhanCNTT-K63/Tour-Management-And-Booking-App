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
            panel1 = new Panel();
            lblDescription = new RichTextBox();
            lblEnding = new Label();
            lblOpening = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(22, 65);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 20);
            lblCountry.TabIndex = 1;
            lblCountry.Text = "label1";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(22, 114);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(50, 20);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "label1";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(22, 159);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(50, 20);
            lblCity.TabIndex = 3;
            lblCity.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(91, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(304, 262);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(557, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(739, 499);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblEnding);
            panel1.Controls.Add(lblOpening);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblCountry);
            panel1.Controls.Add(lblRegion);
            panel1.Controls.Add(lblCity);
            panel1.Location = new Point(12, 323);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 447);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(22, 204);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(384, 142);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "";
            // 
            // lblEnding
            // 
            lblEnding.AutoSize = true;
            lblEnding.Location = new Point(22, 409);
            lblEnding.Name = "lblEnding";
            lblEnding.Size = new Size(50, 20);
            lblEnding.TabIndex = 8;
            lblEnding.Text = "label1";
            // 
            // lblOpening
            // 
            lblOpening.AutoSize = true;
            lblOpening.Location = new Point(22, 363);
            lblOpening.Name = "lblOpening";
            lblOpening.Size = new Size(50, 20);
            lblOpening.TabIndex = 7;
            lblOpening.Text = "label1";
            // 
            // TourDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 820);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox);
            Name = "TourDetail";
            Text = "TourDetail";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private Label lblCountry;
        private Label lblRegion;
        private Label lblCity;
        private PictureBox pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblOpening;
        private Label lblEnding;
        private RichTextBox lblDescription;
    }
}