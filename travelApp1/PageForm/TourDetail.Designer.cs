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
            lblName.Name = "lblName";
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Name = "lblCountry";
            lblCountry.TabIndex = 1;
            lblCountry.Text = "label1";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Name = "lblRegion";
            lblRegion.TabIndex = 2;
            lblRegion.Text = "label1";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Name = "lblCity";
            lblCity.TabIndex = 3;
            lblCity.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Name = "pictureBox";
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Name = "flowLayoutPanel1";
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
            AutoScaleMode = AutoScaleMode.Font;
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