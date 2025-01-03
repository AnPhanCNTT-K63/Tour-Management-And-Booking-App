using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;

namespace travelApp1.PageForm
{
    public partial class TourDetail : Form
    {
        private readonly TourDTO _tour;
        public TourDetail(TourDTO tour)
        {
            InitializeComponent();
            _tour = tour;
            DisplayTourDetails();
        }
        private void DisplayTourDetails()
        {
            // Populate the form with tour details
            lblName.Text = _tour.Name;
            lblRegion.Text = _tour.Region;
            lblCountry.Text = _tour.Country;
            lblCity.Text = _tour.City;
            // Other details (price, description, etc.)
            pictureBox.ImageLocation = _tour.Image;
        }
    }
}
