using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelApp1
{
    public partial class TourManagerForm : Form
    {
        public TourManagerForm()
        {
            InitializeComponent();
            LoadTours();
            toursDataGridView.CellClick += toursDataGridView_CellClick;
        }
        private void LoadTours()
        {
            try
            {
                // Đây là ví dụ dữ liệu mẫu, thay thế bằng dữ liệu từ API hoặc database
                var tours = new List<Tour>
                {
                    new Tour { Id = 1, Name = "Ha Long Bay", Price = 500, Duration = "3 days", Description = "Explore the beauty of Ha Long Bay" },
                    new Tour { Id = 2, Name = "Sa Pa", Price = 300, Duration = "2 days", Description = "Discover the mountains of Sa Pa" },
                    new Tour { Id = 3, Name = "Da Nang", Price = 400, Duration = "4 days", Description = "Relax at the beaches of Da Nang" }
                };

                foreach (var tour in tours)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(toursDataGridView);
                    row.Cells[0].Value = tour.Id;
                    row.Cells[1].Value = tour.Name;
                    row.Cells[2].Value = tour.Price;
                    row.Cells[3].Value = tour.Duration;
                    row.Cells[4].Value = tour.Description;
                    toursDataGridView.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddTourButton_Click(object sender, EventArgs e)
        {
            // Xử lý thêm tour mới
            MessageBox.Show("Add Tour clicked!");
        }

        private void EditTourButton_Click(object sender, EventArgs e)
        {
            // Xử lý chỉnh sửa tour
            MessageBox.Show("Edit Tour clicked!");
        }

        private void DeleteTourButton_Click(object sender, EventArgs e)
        {
            // Xử lý xóa tour
            MessageBox.Show("Delete Tour clicked!");
        }
        private void toursDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = toursDataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột của hàng được chọn và đổ vào các textbox
                txtID.Text = row.Cells["dataGridViewID"].Value?.ToString();
                txtNameOfTour.Text = row.Cells["dataGridViewName"].Value?.ToString();
                textPrice.Text = row.Cells["dataGridViewPrice"].Value?.ToString();
                txtDuration.Text = row.Cells["dataGridViewDuration"].Value?.ToString();
                txtDescription.Text = row.Cells["dataGridViewDescription"].Value?.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem hàng nào đã được chọn
            if (toursDataGridView.SelectedRows.Count > 0)
            {
                // Lấy ID của tour từ hàng được chọn
                var selectedRow = toursDataGridView.SelectedRows[0];
                var tourId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the tour with ID {tourId}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa hàng khỏi DataGridView
                    toursDataGridView.Rows.Remove(selectedRow);

                    // Gọi API hoặc xử lý xóa tour (nếu cần)
                    //DeleteTourFromApi(tourId);
                }
            }
            else
            {
                // Thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Please select a tour to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtNameOfTour.Text) ||
                    string.IsNullOrWhiteSpace(textPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtDuration.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse dữ liệu từ textbox
                int id = int.Parse(txtID.Text);
                string name = txtNameOfTour.Text;
                decimal price = decimal.Parse(textPrice.Text);
                string duration = txtDuration.Text;
                string description = txtDescription.Text;

                // Kiểm tra nếu ID đã tồn tại trong DataGridView
                bool isUpdated = false;
                foreach (DataGridViewRow row in toursDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && (int)row.Cells[0].Value == id)
                    {
                        // Cập nhật hàng hiện có
                        row.Cells[1].Value = name;
                        row.Cells[2].Value = price;
                        row.Cells[3].Value = duration;
                        row.Cells[4].Value = description;
                        isUpdated = true;
                        break;
                    }
                }

                if (!isUpdated)
                {
                    // Thêm hàng mới nếu ID chưa tồn tại
                    var newRow = new DataGridViewRow();
                    newRow.CreateCells(toursDataGridView);
                    newRow.Cells[0].Value = id;
                    newRow.Cells[1].Value = name;
                    newRow.Cells[2].Value = price;
                    newRow.Cells[3].Value = duration;
                    newRow.Cells[4].Value = description;
                    toursDataGridView.Rows.Add(newRow);
                }

                // Hiển thị thông báo lưu thành công
                MessageBox.Show("Tour saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu trong các textbox sau khi lưu
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm để xóa dữ liệu trong các TextBox
        private void ClearTextFields()
        {
            txtID.Clear();
            txtNameOfTour.Clear();
            textPrice.Clear();
            txtDuration.Clear();
            txtDescription.Clear();
        }

    }
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
