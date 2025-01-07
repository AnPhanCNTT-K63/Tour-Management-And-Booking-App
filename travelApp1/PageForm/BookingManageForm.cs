using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class BookingManageForm : Form
    {
        private readonly string apiUrl = "https://localhost:7025/api/booking/user/";
        private readonly ApiService apiService = new ApiService();

        public BookingManageForm()
        {
            InitializeComponent();
            LoadBookingsToGridView();
            AddExportButton();
        }

        // Hiển thị dữ liệu lên DataGridView
        private async void LoadBookingsToGridView()
        {
            try
            {
                var bookings = new List<Booking2DTO>();
                var res = await apiService.GetAsync($"booking/user/{UserIndentity.Id}");

                if (res.IsSuccessStatusCode)
                {
                    var jsonResponse = await res.Content.ReadAsStringAsync();
                    bookings = JsonConvert.DeserializeObject<List<Booking2DTO>>(jsonResponse);
                    Debug.WriteLine(jsonResponse);
                }

                dataGridView1.DataSource = bookings;
                CustomizeGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị dữ liệu: {ex.Message}");
            }
        }

        // Tùy chỉnh DataGridView
        private void CustomizeGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].HeaderText = "Mã Booking";
                dataGridView1.Columns["BookingDate"].HeaderText = "Ngày Đặt";
                dataGridView1.Columns["Status"].HeaderText = "Trạng Thái";
                dataGridView1.Columns["NumOfPeople"].HeaderText = "Số Người";
                dataGridView1.Columns["TourPackageId"].HeaderText = "Mã Gói Tour";
                dataGridView1.Columns["UserId"].HeaderText = "Mã Người Dùng";
                dataGridView1.Columns["CreatedAt"].HeaderText = "Ngày Tạo";
                dataGridView1.Columns["UpdatedAt"].HeaderText = "Ngày Cập Nhật";
                dataGridView1.Columns["DeletedAt"].HeaderText = "Ngày Xóa";
            }
        }

        // Thêm nút Export PDF vào form
        private void AddExportButton()
        {
            Button btnExportPdf = new Button
            {
                Text = "Export PDF",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(100, 30)
            };
            btnExportPdf.Click += BtnExportPdf_Click;
            this.Controls.Add(btnExportPdf);
        }

        // Sự kiện click của nút Export PDF
        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\BookingList.pdf"; // Export to D disk
            ExportDataGridViewToPdf(filePath);
        }

        // Hàm xuất dữ liệu từ DataGridView ra file PDF
        private void ExportDataGridViewToPdf(string fileName)
        {
            try
            {
                using (var doc = new Document(PageSize.A4, 20, 20, 40, 40))
                {
                    PdfWriter.GetInstance(doc, new System.IO.FileStream(fileName, System.IO.FileMode.Create));
                    doc.Open();

                    // Header section
                    var headerTable = new PdfPTable(2);
                    headerTable.WidthPercentage = 100;
                    headerTable.SetWidths(new float[] { 70, 30 });

                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                    var companyInfo = new Paragraph("Travel App\nAddress: 123 Main Street\nPhone: +1 234 567 890\nEmail: contact@travelapp.com\n", normalFont);
                    var invoiceTitle = new Paragraph("INVOICE", titleFont)
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };
                    var invoiceMeta = new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy}\nInvoice #: {Guid.NewGuid()}\n", normalFont)
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };

                    var cell1 = new PdfPCell(companyInfo) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                    var cell2 = new PdfPCell(new Phrase(invoiceTitle)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT };
                    var cell3 = new PdfPCell() { Border = iTextSharp.text.Rectangle.NO_BORDER };
                    var cell4 = new PdfPCell(invoiceMeta) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT };

                    headerTable.AddCell(cell1);
                    headerTable.AddCell(cell2);
                    headerTable.AddCell(cell3);
                    headerTable.AddCell(cell4);

                    doc.Add(headerTable);
                    doc.Add(new Paragraph("\n")); // Add spacing

                    // Booking information table
                    PdfPTable table = new PdfPTable(dataGridView1.Columns.Count)
                    {
                        WidthPercentage = 100,
                        SpacingBefore = 10,
                        SpacingAfter = 10
                    };
                    table.SetWidths(new float[] { 10, 20, 15, 15, 15, 15, 20, 20, 20 }); // Adjust column widths if needed

                    // Add column headers
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        var headerCell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(headerCell);
                    }

                    // Add row data
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            var cellValue = cell.Value?.ToString() ?? string.Empty;
                            var pdfCell = new PdfPCell(new Phrase(cellValue, normalFont))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            table.AddCell(pdfCell);
                        }
                    }

                    doc.Add(table);

                    // Footer section
                    var footerTable = new PdfPTable(1)
                    {
                        WidthPercentage = 100
                    };

                    var footerText = new Paragraph("Thank you for choosing Travel App! We look forward to serving you again.\n", normalFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };

                    footerTable.AddCell(new PdfPCell(footerText) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });
                    doc.Add(footerTable);

                    doc.Close();
                }

                MessageBox.Show("Invoice exported successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
