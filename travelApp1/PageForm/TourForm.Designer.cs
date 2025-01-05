namespace travelApp1.PageForm
{
    partial class TourForm
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
            btnSearch = new Button();
            label1 = new Label();
            comboBoxFilter = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtSearchQuery = new TextBox();
            leftPanel = new Panel();
            logoPictureBox = new PictureBox();
            btnHome = new Button();
            slidePanel = new Panel();
            btnTour = new Button();
            btnProfile = new Button();
            btnAccount = new Button();
            panelWelcome = new Panel();
            lblWelcome = new Label();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(307, 235);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 117);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Search By";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Name", "Country", "City" });
            comboBoxFilter.Location = new Point(307, 117);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(151, 28);
            comboBoxFilter.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(477, 656);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(545, 78);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(477, 117);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(709, 533);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(307, 160);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(147, 27);
            txtSearchQuery.TabIndex = 7;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(128, 128, 255);
            leftPanel.Controls.Add(logoPictureBox);
            leftPanel.Controls.Add(btnHome);
            leftPanel.Controls.Add(slidePanel);
            leftPanel.Controls.Add(btnTour);
            leftPanel.Controls.Add(btnProfile);
            leftPanel.Controls.Add(btnAccount);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 766);
            leftPanel.TabIndex = 8;
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
            // btnHome
            // 
            btnHome.Font = new Font("Arial", 12F);
            btnHome.Location = new Point(10, 160);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(180, 50);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // slidePanel
            // 
            slidePanel.BorderStyle = BorderStyle.FixedSingle;
            slidePanel.Location = new Point(200, 50);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(600, 300);
            slidePanel.TabIndex = 0;
            // 
            // btnTour
            // 
            btnTour.Font = new Font("Arial", 12F);
            btnTour.Location = new Point(10, 235);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(180, 50);
            btnTour.TabIndex = 0;
            btnTour.Text = "Tour";
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Arial", 12F);
            btnProfile.Location = new Point(10, 309);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(180, 50);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            // 
            // btnAccount
            // 
            btnAccount.Font = new Font("Arial", 12F);
            btnAccount.Location = new Point(10, 384);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(180, 50);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "Account";
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.FromArgb(255, 192, 192);
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(200, 0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(1050, 51);
            panelWelcome.TabIndex = 9;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblWelcome.Location = new Point(385, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(326, 32);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to Tours Page";
            // 
            // TourForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 766);
            Controls.Add(panelWelcome);
            Controls.Add(leftPanel);
            Controls.Add(txtSearchQuery);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(comboBoxFilter);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "TourForm";
            Text = "TourForm";
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private ComboBox comboBoxFilter;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtSearchQuery;
        private Panel leftPanel;
        private PictureBox logoPictureBox;
        private Button btnHome;
        private Panel slidePanel;
        private Button btnTour;
        private Button btnProfile;
        private Button btnAccount;
        private Panel panelWelcome;
        private Label lblWelcome;
    }
}