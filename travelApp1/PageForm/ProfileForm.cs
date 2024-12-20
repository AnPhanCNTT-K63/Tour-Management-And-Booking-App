using System;
using System.Windows.Forms;

namespace travelApp1
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();

        }
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Button btnSave;
        private Button btnCancel;
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thêm logic xử lý cho nút Lưu
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Thêm logic xử lý cho nút Hủy
            this.Close(); // Ví dụ: Đóng form
        }

    }
}
