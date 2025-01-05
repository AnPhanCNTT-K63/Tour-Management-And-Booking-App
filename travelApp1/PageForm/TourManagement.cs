using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class TourManagement : Form
    {
        private readonly ApiService _apiService;
        private int _currentPage = 1;
        private const int PageSize = 6;
        private int _totalPages = 1;
        private int _totalTours = 0;
        private QueryTourDTO query;
        private List<TourDTO> _currentTours;

        public TourManagement()
        {
            InitializeComponent();
            _apiService = new ApiService();
            query = new QueryTourDTO();
            _currentTours = new List<TourDTO>();
            InitializeComboBox();
            InitializeDataGridView();
            InitData(_currentPage);
        }

        // Initialize region ComboBox and attach event handlers
        private void InitializeComboBox()
        {
            regionComboBox.Items.AddRange(new[] { "All", "NorthSide", "SouthSide", "EastSide", "WestSide" });
            regionComboBox.SelectedIndex = 0; // Set default to "All"
            comboBoxFilter.SelectedIndex = 0; // Set default to "Name"
            regionComboBox.SelectedIndexChanged += RegionComboBox_SelectedIndexChanged;

        }

        // Load tours with pagination and filters
        public async void InitData(int page, string filterBy = null, string filterValue = null)
        {
            try
            {

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

                var res = await _apiService.GetAsync(url);

                Debug.WriteLine(url);

                if (res.IsSuccessStatusCode)
                {
                    var toursJson = await res.Content.ReadAsStringAsync();
                    var tours = JsonConvert.DeserializeObject<TourResponseDTO>(toursJson);

                    DisplayTours(tours.tours);
                    _totalTours = tours.totalCount;
                    _totalPages = (int)Math.Ceiling((double)_totalTours / PageSize);

                    UpdatePaginationButtons();
                    GeneratePageButtons();
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

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear(); // Clear existing columns if any

            // Add image column
            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Tour Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom // Adjust the image layout
            };
            dataGridView1.Columns.Add(imageColumn);

            // Add columns for Name, Region, City, Country, CreatedAt, UpdatedAt
            dataGridView1.Columns.Add("Name", "Tour Name");
            dataGridView1.Columns.Add("Region", "Region");
            dataGridView1.Columns.Add("City", "City");
            dataGridView1.Columns.Add("Country", "Country");
            dataGridView1.Columns.Add("CreatedAt", "Created At");
            dataGridView1.Columns.Add("UpdatedAt", "Updated At");

            // Add Detail button column
            var detailButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Detail",
                HeaderText = "Actions",
                Text = "Detail",
                UseColumnTextForButtonValue = true // Display "Detail" text on button
            };
            dataGridView1.Columns.Add(detailButtonColumn);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 100; // Adjust row height for images
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Attach event handler for button clicks
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                TourDTO selectedTour = _currentTours[e.RowIndex];

                var form = new TourManagementDetail(selectedTour.Id);
                form.FormClosed += (s, args) => InitData(_currentPage);

                form.ShowDialog();
            }
        }

        private async void DisplayTours(List<TourDTO> tours)
        {
            _currentTours = tours;
            dataGridView1.Rows.Clear();

            foreach (var tour in tours)
            {
                int rowIndex = dataGridView1.Rows.Add();

                Image tourImage = await LoadImageFromUrlAsync("https://d3omtf52mksen3.cloudfront.net/Tours/ba_be_lake.jpg");

                dataGridView1.Rows[rowIndex].Cells["Image"].Value = tourImage;
                dataGridView1.Rows[rowIndex].Cells["Name"].Value = tour.Name;
                dataGridView1.Rows[rowIndex].Cells["Region"].Value = tour.Region;
                dataGridView1.Rows[rowIndex].Cells["City"].Value = tour.City;
                dataGridView1.Rows[rowIndex].Cells["Country"].Value = tour.Country;
                dataGridView1.Rows[rowIndex].Cells["CreatedAt"].Value = tour.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss");
                dataGridView1.Rows[rowIndex].Cells["UpdatedAt"].Value = tour.UpdatedAt?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
            }
        }

        private async Task<Image> LoadImageFromUrlAsync(string imageUrl)
        {

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }


        }


        // Update the state of pagination buttons
        private void UpdatePaginationButtons()
        {
            pageNumberLabel.Text = $"Page {_currentPage} of {_totalPages}";
        }



        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            string selectedRegion = regionComboBox.SelectedItem?.ToString();

            // Set query.region based on the selected region
            if (selectedRegion != "All")
            {
                query.region = selectedRegion;
            }
            else
            {
                query.region = null; // Clear the region filter if "All" is selected
            }

        }


        private void GeneratePageButtons()
        {
            paginationPanel.Controls.Clear();

            // Dynamically create page buttons
            for (int i = 1; i <= _totalPages; i++)
            {
                Button pageButton = new Button
                {
                    Text = i.ToString(),
                    Width = 40,
                    Height = 30,
                    Tag = i // Store page number in Tag property
                };
                pageButton.Click += PageButton_Click;
                paginationPanel.Controls.Add(pageButton);
            }
        }

        private void PageButton_Click(object sender, EventArgs e)
        {
            if (sender is Button pageButton && int.TryParse(pageButton.Tag.ToString(), out int page))
            {
                _currentPage = page;
                InitData(_currentPage); // Load the selected page
            }
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            _currentPage = 1; // Reset to the first page on new search
            string selectedFilter = comboBoxFilter.SelectedItem.ToString();
            string searchQuery = searchTextBox.Text.Trim();

            // Always include the selected region in the query
            string selectedRegion = regionComboBox.SelectedItem?.ToString();
            query.region = selectedRegion != "All" ? selectedRegion : null;

            // Check if there is a valid search query before calling InitData
            if (!string.IsNullOrEmpty(searchQuery))
            {
                InitData(_currentPage, selectedFilter, searchQuery);
            }
            else
            {
                InitData(_currentPage); // Call without filterBy and filterValue if searchQuery is empty
            }
        }

    }
}
