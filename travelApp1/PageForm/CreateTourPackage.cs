using RestSharp;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1
{
    public partial class CreateTourPackage : Form
    {
        private readonly TourDTO _tourDTO;
        private List<PackageDTO> _packages = new List<PackageDTO>();
        private readonly CreateTour _parentForm;
        private readonly ApiService _apiService;

        public CreateTourPackage(TourDTO tourDTO, CreateTour parentForm)
        {
            InitializeComponent();
            _tourDTO = tourDTO;
            _parentForm = parentForm;
            _apiService = new ApiService();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "Images", "default.jpg");

        }
        private async void btnAddPackage_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPackageImage.Text))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh cho package.");
                return;
            }

            // Upload the package image
            var packageImagePath = txtPackageImage.Text;
            var uploadResult = await UploadImageAsync(packageImagePath, "Packages");
            if (string.IsNullOrEmpty(uploadResult))
            {
                MessageBox.Show("Không thể tải lên hình ảnh package.");
                return;
            }

            var package = new PackageDTO
            {
                Name = txtPackageName.Text,
                Description = txtPackageDescription.Text,
                Image = uploadResult, // Use the uploaded image result (file name or URL)
                Price = (int)nudPrice.Value,
                Activities = txtActivities.Text,
                IsChangeSchedule = chkChangeSchedule.Checked,
                IsRefund = chkRefund.Checked,
                Quantity = (int)nudQuantity.Value,
                Vat = nudVat.Value,
                CheckIn = txtCheckIn.Text,
                Schedules = new List<ScheduleDTO>()
            };

            // Add vouchers
            var vouchers = new List<VoucherDTO>();
            foreach (DataGridViewRow row in dgvVouchers.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    vouchers.Add(new VoucherDTO
                    {
                        Title = row.Cells["VoucherTitle"].Value.ToString(),
                        Code = row.Cells["VoucherCode"].Value.ToString(),
                        Discount = Convert.ToDecimal(row.Cells["VoucherDiscount"].Value)
                    });
                }
            }
            package.Vouchers = vouchers;

            // Add travel days
            foreach (DataGridViewRow row in dgvTravelDays.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    var travelDay = new ScheduleDTO
                    {
                        TravelDay = (DateTime)row.Cells[0].Value
                    };
                    package.Schedules.Add(travelDay);
                }
            }

            if (package.Schedules.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một ngày du lịch.");
                return;
            }

            string validationError = package.GetValidationError();
            if (validationError != null)
            {
                MessageBox.Show(validationError);
                return;
            }

            _packages.Add(package);
            MessageBox.Show("Package đã được thêm!");

            var result = MessageBox.Show("Bạn có muốn thêm TourPackage khác?", "Thêm TourPackage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                nudDiscount.Value = 0;
                txtCheckIn.Clear();
                dgvTravelDays.Rows.Clear();
                dgvVouchers.Rows.Clear();
            }
            else
            {
                btnSubmit.Visible = true;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_packages == null || _packages.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một TourPackage để tiếp tục.");
                return;
            }

            var payload = new
            {
                userId = 1,
                tourDTO = _tourDTO,
                createPackageDTO = _packages
            };



            var response = await _apiService.PostAsync("tour/create-tour-and-package", new
            {
                userId = 1,
                tourDTO = _tourDTO,
                createPackageDTO = _packages
            });

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Tạo tour thành công!");
                this.Close();

            }
            else
            {
                MessageBox.Show($"Lỗi: {await response.Content.ReadAsStringAsync()}");
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Only allow image files
                openFileDialog.Title = "Chọn hình ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the full file path in txtPackageImage
                    txtPackageImage.Text = openFileDialog.FileName;

                    // Display the selected image in pictureBox1
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private async Task<string> UploadImageAsync(string imagePath, string folder)
        {
            using (var client = new RestClient($"{Properties.Settings.Default.ApiUrl}"))
            {
                var request = new RestRequest("cloud/upload", Method.Post);
                request.AddFile("file", imagePath);
                request.AddParameter("folder", folder);

                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    // Assuming the API returns the uploaded file's full path or URL
                    string uploadedImageUrl = response.Content.Trim('"');
                    string imageName = Path.GetFileName(uploadedImageUrl); // Extract only the image name
                    return imageName;
                }
                return null;
            }
        }


    }
}
