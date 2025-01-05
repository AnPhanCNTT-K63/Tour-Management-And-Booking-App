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
            logoPictureBox.Location = new Point(69, 11);
            logoPictureBox.Margin = new Padding(4, 4, 4, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(125, 125);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // slidePanel
            // 
            slidePanel.BorderStyle = BorderStyle.FixedSingle;
            slidePanel.Location = new Point(250, 62);
            slidePanel.Margin = new Padding(4, 4, 4, 4);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(750, 374);
            slidePanel.TabIndex = 0;
            // 
            // slidePicture
            // 
            slidePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            slidePicture.Location = new Point(250, 110);
            slidePicture.Margin = new Padding(4, 4, 4, 4);
            slidePicture.Name = "slidePicture";
            slidePicture.Size = new Size(750, 496);
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
            leftPanel.Margin = new Padding(4, 4, 4, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(250, 610);
            leftPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F);
            button1.Location = new Point(12, 140);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(225, 62);
            button1.TabIndex = 3;
            button1.Text = "Home";
            // 
            // btnTour
            // 
            btnTour.Font = new Font("Arial", 12F);
            btnTour.Location = new Point(12, 234);
            btnTour.Margin = new Padding(4, 4, 4, 4);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(225, 62);
            btnTour.TabIndex = 0;
            btnTour.Text = "Tour";
            btnTour.Click += BtnTour_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Arial", 12F);
            btnProfile.Location = new Point(12, 326);
            btnProfile.Margin = new Padding(4, 4, 4, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(225, 62);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.Click += BtnProfile_Click;
            // 
            // btnAccount
            // 
            btnAccount.Font = new Font("Arial", 12F);
            btnAccount.Location = new Point(12, 422);
            btnAccount.Margin = new Padding(4, 4, 4, 4);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(225, 62);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "Account";
            btnAccount.Click += BtnAccount_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblWelcome.Location = new Point(160, 11);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(379, 37);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to Travel App!";
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.FromArgb(255, 192, 192);
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(250, 0);
            panelWelcome.Margin = new Padding(4, 4, 4, 4);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(752, 64);
            panelWelcome.TabIndex = 5;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 610);
            Controls.Add(panelWelcome);
            Controls.Add(slidePicture);
            Controls.Add(leftPanel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ - Travel App";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)slidePicture).EndInit();
            leftPanel.ResumeLayout(false);
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel leftPanel;
        private Button btnTour;
        private Button btnProfile;
        private Button btnAccount;
        private Label lblWelcome;
        private Panel panelWelcome;
        private Button button1;
    }
}