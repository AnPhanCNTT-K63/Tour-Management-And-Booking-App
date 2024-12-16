using System;
using System.Windows.Forms;

namespace travelApp1
{
    public partial class TourForm : Form
    {
        public TourForm()
        {
            InitializeComponent();

            this.Text = "Tour";
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTour = new Label();
            lblTour.Text = "Tour Management";
            lblTour.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblTour.AutoSize = true;
            lblTour.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(lblTour);
        }
    }
}
