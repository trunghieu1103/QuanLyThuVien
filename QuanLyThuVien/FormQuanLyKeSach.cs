using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormQuanLyKeSach : Form
    {
        public FormQuanLyKeSach(string username)
        {
            InitializeComponent();
            txtUsername.Text = username; // Hiển thị tên đăng nhập trên TextBox
            txtUsername.Hide(); 
        }

        private void FormQuanLyKeSach_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormTrangChu formTrangChu = new FormTrangChu(txtUsername.Text);
                formTrangChu.Show();
                this.Close(); // Đóng form quản lý kệ sách sau khi mở form Trang Chủ
            }
        }
    }
}
