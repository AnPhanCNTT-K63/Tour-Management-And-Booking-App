using Newtonsoft.Json;
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
using travelApp1.Services;


namespace travelApp1.PageForm
{
    public partial class PaymentManage : Form
    {
        private readonly ApiService _service;
        private List<PaymentDTO> _payments;
        private int _currentPage = 1;
        private const int RowsPerPage = 5;

        private Label pageNumberLabel;

        public PaymentManage()
        {
            InitializeComponent();
            _service = new ApiService();
            _payments = new List<PaymentDTO>();
            InitializeComboBox();
            InitData();
            InitializeDataGridView();

            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        {
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private async void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString().ToLower();

            switch (selectedValue)
            {
                case "all":
                    await FetchPayments("payment/request");
                    break;

                case "waiting":
                    await FetchPayments("payment/request/pending");
                    break;

                case "accept":
                    await FetchPayments("payment/request/accepted");
                    break;

                case "decline":
                    await FetchPayments("payment/request/unaccepted");
                    break;

                case "processed":
                    await FetchPayments("payment/request/processed");
                    break;
            }
        }

        private async Task FetchPayments(string endpoint)
        {
            try
            {

                if (res.IsSuccessStatusCode)
                {
                    var data = await res.Content.ReadAsStringAsync();

                }
                else if (status == "fail")
                {
                    // Replace Decline button with a text cell showing "✘ Failed"
                    dataGridView1.Rows[rowIndex].Cells[10] = new DataGridViewTextBoxCell
                    {
                        Value = "✘ Failed"
                    };
                    dataGridView1.Rows[rowIndex].Cells[10].Style.ForeColor = Color.Red;
                    dataGridView1.Rows[rowIndex].Cells[10].ReadOnly = true;

                    // Replace Accept button with an empty text cell
                    dataGridView1.Rows[rowIndex].Cells[9] = new DataGridViewTextBoxCell
                    {
                        Value = ""
                    };
                }
                else
                {
                    // Attach booking ID for button actions if status is not success or fail
                    dataGridView1.Rows[rowIndex].Cells[9].Tag = payment.BookingId; // Accept button
                    dataGridView1.Rows[rowIndex].Cells[10].Tag = payment.BookingId; // Decline button
                }
            }

            // Force the DataGridView to refresh
            dataGridView1.Refresh();

            pageNumberLabel.Text = $"Page {page}";
        }





        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Accept" ||
                dataGridView1.Columns[e.ColumnIndex].HeaderText == "Decline")
            {
                var status = dataGridView1.Rows[e.RowIndex].Cells["PaymentStatus"].Value?.ToString().ToLower();

                if (status == "success" || status == "fail")
                {

                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                DisplayPage(_currentPage);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int totalPages = (_payments.Count + RowsPerPage - 1) / RowsPerPage; // Calculate total pages
            if (_currentPage < totalPages)
            {
                _currentPage++;
                DisplayPage(_currentPage);
            }
        }

        private void GeneratePageButtons()
        {
            int totalPages = (_payments.Count + RowsPerPage - 1) / RowsPerPage;
            int buttonWidth = 40;
            int buttonHeight = 30;
            int buttonSpacing = 5;
            int startX = 400;
            int startY = 350;

            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text != "Previous" && control.Text != "Next")
                {
                    control.Dispose();
                }
            }

            for (int i = 1; i <= totalPages; i++)
            {
                Button pageButton = new Button
                {
                    Text = i.ToString(),
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(startX + (i - 1) * (buttonWidth + buttonSpacing), startY),
                    Tag = i
                };
                pageButton.Click += PageButton_Click;
                this.Controls.Add(pageButton);
            }
        }

        private void PageButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int page = (int)clickedButton.Tag;
            _currentPage = page;
            DisplayPage(_currentPage);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var status = dataGridView1.Rows[e.RowIndex].Cells["PaymentStatus"].Value?.ToString().ToLower();

                // Ignore clicks if status is "success" or "fail"
                if (status == "success" || status == "fail")
                {
                    return;
                }

                var clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && clickedCell.OwningColumn.HeaderText == "Accept")
                {
                    var bookingId = dataGridView1.Rows[e.RowIndex].Cells[9].Tag.ToString();
                    MessageBox.Show($"Accepted booking with ID: {bookingId}", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProcessAccept(bookingId);
                }
                else if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && clickedCell.OwningColumn.HeaderText == "Decline")
                {
                    var bookingId = dataGridView1.Rows[e.RowIndex].Cells[10].Tag.ToString();
                    MessageBox.Show($"Declined booking with ID: {bookingId}", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProcessDecline(bookingId);
                }
            }
        }

        private async void ProcessAccept(string bookingId)
        {
            try
            {
                var res = await _service.PatchAsync($"booking/update-status/{bookingId}", new { status = "success" });

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Booking accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await InitData();
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

        private async void ProcessDecline(string bookingId)
        {
            try
            {
                var res = await _service.PatchAsync($"booking/update-status/{bookingId}", new { status = "fail" });

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Booking declined successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await InitData();
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
}
