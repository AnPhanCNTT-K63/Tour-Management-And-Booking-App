namespace travelApp1
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            logoPictureBox = new PictureBox();
            slidePanel = new Panel();
            slidePicture = new PictureBox();
            slideTimer = new System.Windows.Forms.Timer(components);
            btnViewTour = new Button();
            btnBooking = new Button();
            leftPanel = new Panel();
            button1 = new Button();
            btnTour = new Button();
            btnProfile = new Button();
            btnAccount = new Button();
            lblWelcome = new Label();
            panelWelcome = new Panel();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slidePicture).BeginInit();
            leftPanel.SuspendLayout();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Location = new Point(55, 9);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(100, 100);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // slidePanel
            // 
            slidePanel.BorderStyle = BorderStyle.FixedSingle;
            slidePanel.Location = new Point(200, 50);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(600, 300);
            slidePanel.TabIndex = 0;
            // 
            // slidePicture
            // 
            slidePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            slidePicture.Location = new Point(200, 88);
            slidePicture.Name = "slidePicture";
            slidePicture.Size = new Size(600, 300);
            slidePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            slidePicture.TabIndex = 0;
            slidePicture.TabStop = false;
            // 
            // slideTimer
            // 
            slideTimer.Enabled = true;
            slideTimer.Interval = 3000;
            slideTimer.Tick += SlideTimer_Tick;
            // 
            // btnViewTour
            // 
            btnViewTour.AutoSize = true;
            btnViewTour.Font = new Font("Arial", 12F);
            btnViewTour.Location = new Point(218, 412);
            btnViewTour.Name = "btnViewTour";
            btnViewTour.Size = new Size(104, 33);
            btnViewTour.TabIndex = 1;
            btnViewTour.Text = "Xem Tour";
            btnViewTour.Click += BtnViewTour_Click;
            // 
            // btnBooking
            // 
            btnBooking.AutoSize = true;
            btnBooking.Font = new Font("Arial", 12F);
            btnBooking.Location = new Point(580, 412);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(95, 33);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "Đặt Tour";
            btnBooking.Click += BtnBooking_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(128, 128, 255);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Controls.Add(button1);
            leftPanel.Controls.Add(slidePanel);
            leftPanel.Controls.Add(btnTour);
            leftPanel.Controls.Add(btnProfile);
            leftPanel.Controls.Add(btnAccount);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 488);
            leftPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F);
            button1.Location = new Point(10, 112);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 3;
            button1.Text = "Home";
            // 
            // btnTour
            // 
            btnTour.Font = new Font("Arial", 12F);
            btnTour.Location = new Point(10, 187);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(180, 50);
            btnTour.TabIndex = 0;
            btnTour.Text = "Tour";
            btnTour.Click += BtnTour_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Arial", 12F);
            btnProfile.Location = new Point(10, 261);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(180, 50);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.Click += BtnProfile_Click;
            // 
            // btnAccount
            // 
            btnAccount.Font = new Font("Arial", 12F);
            btnAccount.Location = new Point(10, 338);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(180, 50);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "Account";
            btnAccount.Click += BtnAccount_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblWelcome.Location = new Point(128, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(326, 32);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to Travel App!";
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.FromArgb(255, 192, 192);
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(200, 0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(602, 51);
            panelWelcome.TabIndex = 5;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 488);
            Controls.Add(panelWelcome);
            Controls.Add(slidePicture);
            Controls.Add(btnViewTour);
            Controls.Add(btnBooking);
            Controls.Add(leftPanel);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ - Travel App";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)slidePicture).EndInit();
            leftPanel.ResumeLayout(false);
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewTour;
        private Button btnBooking;
        private Panel leftPanel;
        private Button btnTour;
        private Button btnProfile;
        private Button btnAccount;
        private Label lblWelcome;
        private Panel panelWelcome;
        private Button button1;
    }
}