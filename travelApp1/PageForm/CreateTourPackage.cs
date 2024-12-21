using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using travelApp1.Models;

namespace travelApp1
{
    public partial class CreateTourPackage : Form
    {
        private readonly TourDTO _tourDTO; // Lưu thông tin tour được truyền từ CreateTour
        private List<PackageDTO> _packages = new List<PackageDTO>(); // Danh sách package
        private readonly CreateTour _parentForm;

        public CreateTourPackage(TourDTO tourDTO, CreateTour parentForm)
        {
            InitializeComponent();
            _tourDTO = tourDTO;
            _parentForm = parentForm;
        }
        private void btnAddPackage_Click_1(object sender, EventArgs e)
        {
            // Tạo đối tượng PackageDTO từ giao diện
            var package = new PackageDTO
            {
                Name = txtPackageName.Text,
                Description = txtPackageDescription.Text,
                Image = txtPackageImage.Text,
                Price = (int)nudPrice.Value,
                Activities = txtActivities.Text,
                IsChangeSchedule = chkChangeSchedule.Checked,
                IsRefund = chkRefund.Checked,
                Quantity = (int)nudQuantity.Value,
                Vat = nudVat.Value,
                CheckIn = txtCheckIn.Text,
                Schedules = new List<ScheduleDTO>()
            };

            // Thêm danh sách Voucher từ dgvVouchers
            var vouchers = new List<VoucherDTO>();
            foreach (DataGridViewRow row in dgvVouchers.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) // Kiểm tra các ô không rỗng
                {
                    vouchers.Add(new VoucherDTO
                    {
                        Title = row.Cells["VoucherTitle"].Value.ToString(),
                        Code = row.Cells["VoucherCode"].Value.ToString(),
                        Discount = Convert.ToDecimal(row.Cells["VoucherDiscount"].Value)
                    });
                }
            }
            package.Vouchers = vouchers; // Gán danh sách Voucher vào PackageDTO

            // Lấy tất cả ngày du lịch từ DataGridView (hoặc một danh sách khác)
            foreach (DataGridViewRow row in dgvTravelDays.Rows)
            {
                if (row.Cells[0].Value != null) // Kiểm tra ngày du lịch không rỗng
                {
                    var travelDay = new ScheduleDTO
                    {
                        TravelDay = (DateTime)row.Cells[0].Value // Giả sử column 0 là ngày du lịch
                    };
                    package.Schedules.Add(travelDay); // Thêm ngày du lịch vào package
                }
            }

            // Kiểm tra nếu không có ngày du lịch nào được thêm
            if (package.Schedules.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một ngày du lịch.");
                return;
            }

            // Kiểm tra tính hợp lệ của PackageDTO
            string validationError = package.GetValidationError();
            if (validationError != null)
            {
                MessageBox.Show(validationError);
                return;
            }
            else
            {
                // Thêm package vào danh sách
                _packages.Add(package);
                MessageBox.Show("Package đã được thêm!");

                // Hiển thị hộp thoại yêu cầu người dùng quyết định có thêm gói tour nữa không
                var result = MessageBox.Show("Bạn có muốn thêm TourPackage khác?", "Thêm TourPackage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Nếu "Có", giữ cửa sổ CreateTourPackage mở để tiếp tục thêm gói tour
                    txtPackageName.Clear();
                    txtPackageDescription.Clear();
                    txtPackageImage.Clear();
                    nudPrice.Value = 0;
                    txtActivities.Clear();
                    chkChangeSchedule.Checked = false;
                    chkRefund.Checked = false;
                    nudQuantity.Value = 0;
                    nudVat.Value = 0;
                    dtpTravelDay.Value = DateTime.Now;
                    txtVoucherTitle.Clear();
                    txtVoucherCode.Clear();
                    nudDiscount.Value = 0;
                    txtCheckIn.Clear();
                    dgvTravelDays.Rows.Clear(); // Xóa hết các dòng đã nhập trong DataGridView
                    dgvVouchers.Rows.Clear(); // Xóa hết các Voucher đã thêm
                }
                else
                {
                    // Nếu "Không", chuyển sang nút Submit để kết thúc việc tạo tour
                    btnSubmit.Visible = true;
                }
            }
        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Kiểm tra danh sách packages
            if (_packages == null || _packages.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một TourPackage để tiếp tục.");
                return;
            }

            // Chuẩn bị payload
            var payload = new
            {
                userId = 1, // ID admin
                tourDTO = _tourDTO,
                createPackageDTO = _packages
            };

            string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);

            // Gửi API bằng HttpClient
            using (var client = new HttpClient())
            {
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7025/api/tour/create-tour-and-package", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tạo tour thành công!");
                    this.Close(); // Đóng cửa sổ CreateTourPackage
                    var createTourForm = new CreateTour(); // Mở lại cửa sổ CreateTour
                    createTourForm.Show();
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response.ReasonPhrase}");
                    MessageBox.Show(jsonPayload.ToString());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPackageName.Clear();
            txtPackageDescription.Clear();
            txtPackageImage.Clear();
            nudPrice.Value = 0;
            txtActivities.Clear();
            chkChangeSchedule.Checked = false;
            chkRefund.Checked = false;
            nudQuantity.Value = 0;
            nudVat.Value = 0;
            dtpTravelDay.Value = DateTime.Now;
            txtVoucherTitle.Clear();
            txtVoucherCode.Clear();
            txtCheckIn.Clear();
            nudDiscount.Value = 0;
        }

        private void btnAddTravelDay_Click(object sender, EventArgs e)
        {
            if (dgvTravelDays.Columns.Count == 0)
            {
                MessageBox.Show("Vui lòng cấu hình cột cho DataGridView trước.");
                return;
            }

            // Thêm dòng mới vào DataGridView
            dgvTravelDays.Rows.Add(dtpTravelDay.Value);
            // Thêm một dòng mới vào DataGridView khi người dùng nhấn nút "Thêm ngày du lịch"
            if (!dgvTravelDays.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[0].Value?.ToString() == dtpTravelDay.Value.ToString()))
            {
                dgvTravelDays.Rows.Add(dtpTravelDay.Value); // Sử dụng dtpTravelDay để lấy ngày du lịch
            }
            else
            {
                MessageBox.Show("Ngày du lịch này đã được thêm!");
            }
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            // Kiểm tra các giá trị không rỗng
            if (string.IsNullOrWhiteSpace(txtVoucherTitle.Text) || string.IsNullOrWhiteSpace(txtVoucherCode.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Voucher.");
                return;
            }

            // Kiểm tra nếu mã Voucher đã tồn tại trong danh sách
            foreach (DataGridViewRow row in dgvVouchers.Rows)
            {
                if (row.Cells["VoucherCode"].Value?.ToString() == txtVoucherCode.Text)
                {
                    MessageBox.Show("Mã Voucher này đã tồn tại!");
                    return;
                }
            }

            // Thêm Voucher vào DataGridView
            dgvVouchers.Rows.Add(txtVoucherTitle.Text, txtVoucherCode.Text, nudDiscount.Value);

            // Xóa các giá trị nhập sau khi thêm
            txtVoucherTitle.Clear();
            txtVoucherCode.Clear();
            nudDiscount.Value = 0;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để chọn file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ cho phép chọn file ảnh
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên file từ đường dẫn
                    string fileName = System.IO.Path.GetFileName(openFileDialog.FileName);

                    // Gán tên file vào txtPackageImage
                    txtPackageImage.Text = fileName;

                    // Sao chép ảnh vào thư mục lưu trữ (nếu cần)
                    string destinationPath = System.IO.Path.Combine(Application.StartupPath, "Images", fileName);
                    if (!System.IO.Directory.Exists(System.IO.Path.Combine(Application.StartupPath, "Images")))
                    {
                        System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.StartupPath, "Images"));
                    }
                    System.IO.File.Copy(openFileDialog.FileName, destinationPath, true); // Ghi đè nếu file tồn tại
                }
            }
        }
    }
}
