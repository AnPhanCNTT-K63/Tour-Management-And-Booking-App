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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }


        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button changeAvatarButton;

        // Xử lý sự kiện lưu thông tin
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Lưu thông tin profile ở đây (ví dụ: ghi vào file, database, hoặc thông báo)
            MessageBox.Show("Profile saved!");
        }

        // Xử lý sự kiện hủy bỏ
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Đóng form hoặc quay lại màn hình trước
            this.Close();
        }

        // Xử lý thay đổi avatar
        private void ChangeAvatarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Lọc các loại file hình ảnh
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.avatarPictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
