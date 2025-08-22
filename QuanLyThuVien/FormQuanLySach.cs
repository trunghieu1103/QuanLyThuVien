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
    public partial class FormQuanLySach : Form
    {
        public FormQuanLySach(string username)
        {
            InitializeComponent();
            textBox1.Text = username; // Hiển thị tên đăng nhập trên TextBox
            textBox1.ReadOnly = true; // Đặt TextBox chỉ đọc để người dùng không thể chỉnh sửa tên đăng nhập
            textBox1.Hide(); // Ẩn TextBox nếu không cần thiết hiển thị tên đăng nhập
        }
        
        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            
                FormTrangChu formTrangChu = new FormTrangChu(textBox1.Text);
                formTrangChu.Show();
                this.Close(); // Đóng form quản lý sách sau khi mở form Trang Chủ
            
            
        }

        
    }
}
