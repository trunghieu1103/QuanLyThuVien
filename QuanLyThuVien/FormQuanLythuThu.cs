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
    public partial class FormQuanLythuThu : Form
    {
        public FormQuanLythuThu(string Username)
        {
            InitializeComponent();
            label1.Text = Username; // Hiển thị tên đăng nhập trên Label
            label1.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                FormTrangChu formTrangChu = new FormTrangChu(label1.Text);
                formTrangChu.Show();
            }
        }
    }
}
