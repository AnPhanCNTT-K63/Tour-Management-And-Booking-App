using System;
using System.Drawing;
using System.Windows.Forms;

namespace travelApp1.PageForm
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            InitializeAdminUI();
        }

        private void InitializeAdminUI()
        {
            this.Text = "Admin Dashboard";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Panel for header
            var headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.DarkSlateBlue
            };
            var headerLabel = new Label
            {
                Text = "Admin Dashboard",
                ForeColor = Color.White,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            headerPanel.Controls.Add(headerLabel);
            this.Controls.Add(headerPanel);

            // Panel for buttons
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(50),
                AutoScroll = true
            };

            // Create Tour Button
            var btnCreateTour = CreateButton("Create Tour and Package", BtnCreateTour_Click);
            buttonPanel.Controls.Add(btnCreateTour);

            // Manage Payment Requests Button
            var btnManagePayments = CreateButton("Manage Payment Requests", BtnManagePayments_Click);
            buttonPanel.Controls.Add(btnManagePayments);

            // Manage Tours Button
            var btnManageTours = CreateButton("Manage Tours", BtnManageTours_Click);
            buttonPanel.Controls.Add(btnManageTours);

            // Manage Trash Tours Button
            var btnTrashTourManagement = CreateButton("Manage Trash Tours", BtnTrashTourManagement_Click);
            buttonPanel.Controls.Add(btnTrashTourManagement);

            // Sign Out Button
            var btnSignOut = CreateButton("Sign Out", BtnSignOut_Click);
            btnSignOut.BackColor = Color.IndianRed;
            buttonPanel.Controls.Add(btnSignOut);

            // Add button panel to form
            this.Controls.Add(buttonPanel);
        }

        // Helper method to create styled buttons
        private Button CreateButton(string text, EventHandler onClick)
        {
            return new Button
            {
                Text = text,
                Width = 300,
                Height = 80,
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(20)
            }.AddClickHandler(onClick);
        }

        // Event handler for Create Tour button
        private void BtnCreateTour_Click(object sender, EventArgs e)
        {
            var createTourForm = new CreateTour();
            createTourForm.ShowDialog();
        }

        // Event handler for Manage Payment Requests button
        private void BtnManagePayments_Click(object sender, EventArgs e)
        {
            var paymentRequestForm = new PaymentManage();
            paymentRequestForm.ShowDialog();
        }

        // Event handler for Manage Tours button
        private void BtnManageTours_Click(object sender, EventArgs e)
        {
            var manageTourForm = new TourManagement();
            manageTourForm.ShowDialog();
        }

        // Event handler for Manage Trash Tours button
        private void BtnTrashTourManagement_Click(object sender, EventArgs e)
        {
            var trashTourForm = new TrashTourManagement();
            trashTourForm.ShowDialog();
        }

        // Event handler for Sign Out button
        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            // Clear the stored access token
            Properties.Settings.Default.AccessToken = "";
            Properties.Settings.Default.Save();

            // Close the current form and navigate back to SignIn form
            MessageBox.Show("You have signed out successfully.", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var form = new HomeForm();
            form.Show();
            this.Close();
        }
    }

    // Extension method to add click handlers to buttons
    public static class ButtonExtensions
    {
        public static Button AddClickHandler(this Button button, EventHandler onClick)
        {
            button.Click += onClick;
            return button;
        }
    }
}
