using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.Services;
using static Google.Apis.Requests.BatchRequest;

namespace travelApp1.PageForm
{
    public partial class BookingManageForm : Form
    {
        private int userId = 2; // Thay bằng userId thực tế của bạn
        private readonly string apiUrl = "https://localhost:7025/api/booking/user/";
        private readonly ApiService apiService = new ApiService();

        public BookingManageForm()
        {
            InitializeComponent();
            LoadBookingsToGridView();
        }

        // Phương thức lấy danh sách Booking từ API
        //private async Task<List<Booking2DTO>> GetBookingsAsync(int userId)
        //{
        //    try
        //    {
        //        var res = await apiService.GetAsync($"booking/user/2");

        //        if(res.IsSuccessStatusCode)
        //        {
        //            var jsonResponse = await res.Content.ReadAsStringAsync();
        //            var bookings = JsonSerializer.Deserialize<List<Booking2DTO>>(jsonResponse, new JsonSerializerOptions());
        //            return bookings;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi lấy dữ liệu từ API: {ex.Message}");
        //        return new List<Booking2DTO>();
        //    }
            
        //}

        // Hiển thị dữ liệu lên DataGridView
        private async void LoadBookingsToGridView()
        {
            try
            {
                var bookings = new List<Booking2DTO>();
                var res = await apiService.GetAsync($"booking/user/2");

                if (res.IsSuccessStatusCode)
                {
                    var jsonResponse = await res.Content.ReadAsStringAsync();
                     bookings = JsonConvert.DeserializeObject<List<Booking2DTO>>(jsonResponse);
                    Debug.WriteLine(jsonResponse);
                }

                // Gán dữ liệu cho DataGridView
                dataGridView1.DataSource = bookings;

                // Tuỳ chỉnh cột
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

        // Sự kiện load form
        private void BookingManageForm_Load(object sender, EventArgs e)
        {
            LoadBookingsToGridView();
        }

        // Sự kiện click trong DataGridView (nếu cần xử lý)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tùy chỉnh xử lý khi click vào ô trong DataGridView
            MessageBox.Show($"Bạn đã click vào hàng {e.RowIndex + 1}, cột {e.ColumnIndex + 1}");
        }
    }

}
