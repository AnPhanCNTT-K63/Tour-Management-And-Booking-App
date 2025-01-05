using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;
using static Google.Apis.Requests.BatchRequest;

namespace travelApp1.PageForm
{
    public partial class TourForm : Form
    {
        private readonly ApiService _service;
        private int _currentPage = 1;
        private const int PageSize = 6;
        private int _totalPages = 1;
        private int _totalTours = 0;
        public TourForm()
        {
            InitializeComponent();
            _service = new ApiService();
            InitData(_currentPage);
            logoPictureBox.Image = Image.FromFile("Images/logo.png");
            flowLayoutPanel1.AutoScroll = true;
        }

        public async void InitData(int page, string filterBy = null, string filterValue = null)
        {
            try
            {
                var query = new QueryTourDTO();

                if (!string.IsNullOrEmpty(filterBy) && !string.IsNullOrEmpty(filterValue))
                {
                    if (filterBy == "Name")
                    {
                        query.searchBy = "name";
                        query.searchQuery = filterValue;
                    }
                    else if (filterBy == "Country")
                    {
                        query.searchBy = "country";
                        query.searchQuery = filterValue;
                    }
                    else if (filterBy == "City")
                    {
                        query.searchBy = "city";
                        query.searchQuery = filterValue;
                    }
                }

                var queryParams = new List<string>();

                if (!string.IsNullOrEmpty(query.region)) queryParams.Add($"region={query.region}");
                if (!string.IsNullOrEmpty(query.searchBy)) queryParams.Add($"searchBy={query.searchBy}");
                if (!string.IsNullOrEmpty(query.searchQuery)) queryParams.Add($"searchQuery={query.searchQuery}");
                if (!string.IsNullOrEmpty(query.sortBy)) queryParams.Add($"sortBy={query.sortBy}");
                if (query.priceRange != null && query.priceRange.Length > 0) queryParams.Add($"priceRange={string.Join(",", query.priceRange)}");

                var queryString = string.Join("&", queryParams);

                var url = $"tour/get/{page}/{PageSize}";
                if (!string.IsNullOrEmpty(queryString)) url += $"?{queryString}";

                var res = await _service.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    var toursJson = await res.Content.ReadAsStringAsync();
                    var tours = JsonConvert.DeserializeObject<TourResponseDTO>(toursJson);

                    DisplayTours(tours.tours.Where(t => t.IsDeleted == false).ToList());
                    _totalTours = tours.totalCount;

                    UpdatePageNumbers();
                }
                else
                {
                    MessageBox.Show(await res.Content.ReadAsStringAsync(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTours(List<TourDTO> tours)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var tour in tours)
            {
                var panel = new Panel
                {
                    Width = flowLayoutPanel1.Width - 30,
                    Height = 245,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    Tag = tour
                };

                var pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    ImageLocation = $"{CloudHelper.CloudUri}/Tours/{tour.Image}",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var nameLabel = new Label
                {
                    Text = $"Name: {tour.Name}",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(200, 10)
                };

                var regionLabel = new Label
                {
                    Text = $"Region: {tour.Region}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 40)
                };

                var countryLabel = new Label
                {
                    Text = $"Country: {tour.Country}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 70)
                };

                var cityLabel = new Label
                {
                    Text = $"City: {tour.City}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 100)
                };

                var descriptionLabel = new Label
                {
                    Text = $"Description: {tour.Description}",
                    AutoSize = true,
                    MaximumSize = new Size(panel.Width - 220, 60),
                    Font = new Font("Arial", 9, FontStyle.Italic),
                    ForeColor = Color.DarkGray,
                    Location = new Point(200, 130)
                };

                var btnDetail = new Button
                {
                    Text = "View Details",
                    Width = 120,
                    Height = 35,
                    Location = new Point(200, 200),
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat
                };

                btnDetail.Click += (sender, e) => OpenTourDetailForm(tour);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(regionLabel);
                panel.Controls.Add(countryLabel);
                panel.Controls.Add(cityLabel);
                panel.Controls.Add(descriptionLabel);
                panel.Controls.Add(btnDetail);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }


        private void OpenTourDetailForm(TourDTO selectedTour)
        {
            var detailForm = new TourDetail(selectedTour);
            detailForm.Show();
        }

        private void UpdatePageNumbers()
        {

            _totalPages = (int)Math.Ceiling((double)_totalTours / PageSize);

            flowLayoutPanel2.Controls.Clear();

            for (int i = 1; i <= _totalPages; i++)
            {
                var pageButton = new Button
                {
                    Text = i.ToString(),
                    Width = 30,
                    Height = 30,
                    Margin = new Padding(2),
                    Tag = i
                };

                pageButton.Click += PageButton_Click;
                flowLayoutPanel2.Controls.Add(pageButton);
            }
        }

        private void PageButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            int pageNumber = (int)button.Tag;

            _currentPage = pageNumber;
            InitData(_currentPage);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedFilter = comboBoxFilter.SelectedItem.ToString();
            string searchQuery = txtSearchQuery.Text;

            InitData(_currentPage, selectedFilter, searchQuery);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
    }
}
