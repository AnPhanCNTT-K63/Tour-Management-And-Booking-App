using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class TrashTourManagement : Form
    {
        private readonly ApiService _apiService;
        private int _currentPage = 1;
        private const int PageSize = 6;
        private int _totalPages = 1;
        private int _totalDeletedTours = 0;
        private List<TourDTO> _deletedTours;

        public TrashTourManagement()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _deletedTours = new List<TourDTO>();
            InitializeDataGridView();
            LoadDeletedTours(_currentPage);
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Tour Name");
            dataGridView1.Columns.Add("Region", "Region");
            dataGridView1.Columns.Add("City", "City");
            dataGridView1.Columns.Add("Country", "Country");
            dataGridView1.Columns.Add("DeletedAt", "Deleted At");

            var restoreButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Restore",
                HeaderText = "Actions",
                Text = "Restore",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(restoreButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "Permanently Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButtonColumn);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private async void LoadDeletedTours(int page)
        {
            try
            {
                var url = $"tour/trash/{page}/{PageSize}";
                var res = await _apiService.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    var toursJson = await res.Content.ReadAsStringAsync();
                    var tours = JsonConvert.DeserializeObject<TourResponseDTO>(toursJson);

                    DisplayDeletedTours(tours.tours);
                    _totalDeletedTours = tours.totalCount;
                    _totalPages = (int)Math.Ceiling((double)_totalDeletedTours / PageSize);

                    UpdatePaginationButtons();
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

        private void DisplayDeletedTours(List<TourDTO> tours)
        {
            _deletedTours = tours;
            dataGridView1.Rows.Clear();

            foreach (var tour in tours)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Name"].Value = tour.Name;
                dataGridView1.Rows[rowIndex].Cells["Region"].Value = tour.Region;
                dataGridView1.Rows[rowIndex].Cells["City"].Value = tour.City;
                dataGridView1.Rows[rowIndex].Cells["Country"].Value = tour.Country;
                dataGridView1.Rows[rowIndex].Cells["DeletedAt"].Value = tour.UpdatedAt?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TourDTO selectedTour = _deletedTours[e.RowIndex];

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Restore")
                {
                    RestoreTour(selectedTour.Id);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    PermanentlyDeleteTour(selectedTour.Id);
                }
            }
        }

        private async void RestoreTour(int tourId)
        {
            try
            {
                var res = await _apiService.PostAsync($"tour/restore/{tourId}", null);

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tour restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDeletedTours(_currentPage);
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

        private async void PermanentlyDeleteTour(int tourId)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to permanently delete this tour?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var res = await _apiService.DeleteAsync($"tour/delete/{tourId}");

                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Tour permanently deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDeletedTours(_currentPage);
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
        }

        private void UpdatePaginationButtons()
        {
            pageNumberLabel.Text = $"Page {_currentPage} of {_totalPages}";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadDeletedTours(_currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadDeletedTours(_currentPage);
            }
        }
    }
}
