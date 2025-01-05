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
            btnSignUp = new Button();
            btnSignIn = new Button();
            btnHome = new Button();
            btnTour = new Button();
            btnProfile = new Button();
            btnAccount = new Button();
            lblWelcome = new Label();
            panelWelcome = new Panel();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            btnSignOut = new Button();
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
            slidePanel.Location = new Point(1172, 637);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(11, 10);
            slidePanel.TabIndex = 0;
            // 
            // slidePicture
            // 
            slidePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            slidePicture.Location = new Point(1172, 637);
            slidePicture.Name = "slidePicture";
            slidePicture.Size = new Size(21, 58);
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
            leftPanel.Controls.Add(btnSignOut);
            leftPanel.Controls.Add(btnSignUp);
            leftPanel.Controls.Add(btnSignIn);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Controls.Add(btnHome);
            leftPanel.Controls.Add(btnTour);
            leftPanel.Controls.Add(btnProfile);
            leftPanel.Controls.Add(btnAccount);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(207, 695);
            leftPanel.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Arial", 12F);
            btnSignUp.Location = new Point(103, 414);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(89, 50);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Arial", 12F);
            btnSignIn.Location = new Point(12, 414);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(85, 50);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Arial", 12F);
            btnHome.Location = new Point(10, 112);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(180, 50);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
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
            lblWelcome.Location = new Point(274, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(326, 32);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to Travel App!";
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.FromArgb(255, 192, 192);
            panelWelcome.Controls.Add(label1);
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(207, 0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(986, 51);
            panelWelcome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(794, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 12F);
            button3.Location = new Point(432, 614);
            button3.Name = "button3";
            button3.Size = new Size(180, 50);
            button3.TabIndex = 6;
            button3.Text = "Xem Tour";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 12F);
            button4.Location = new Point(678, 614);
            button4.Name = "button4";
            button4.Size = new Size(180, 50);
            button4.TabIndex = 7;
            button4.Text = "Đặt Tour";
            button4.Click += button4_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Font = new Font("Arial", 12F);
            btnSignOut.Location = new Point(12, 520);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(180, 50);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Sign Out";
            btnSignOut.Click += btnSignOut_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 695);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panelWelcome);
            Controls.Add(slidePicture);
            Controls.Add(slidePanel);
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
        }

        #endregion
        private Panel leftPanel;
        private Button btnTour;
        private Button btnProfile;
        private Button btnAccount;
        private Label lblWelcome;
        private Panel panelWelcome;
        private Button btnHome;
        private Button btnSignUp;
        private Button btnSignIn;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button btnSignOut;
    }
}