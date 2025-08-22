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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu(string username)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "User: " + username; // Hiển thị tên đăng nhập trên StatusStrip

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();

                this.Close(); // Đóng form Trang Chủ sau khi đăng xuất

            }

        }

        private void báoCáoSốLượngSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoSốLượngSáchĐượcMượnTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kryptonStatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLySach formQuanLySach = new FormQuanLySach();
            formQuanLySach.Show();
            this.Close();
        }
    }
}
