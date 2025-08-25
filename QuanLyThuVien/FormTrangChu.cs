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

            toolStripStatusLabel1.Text = username;// Hiển thị tên đăng nhập trên StatusStrip
            toolStripMenuItem1.Enabled = false; // Vô hiệu hóa menu "Đăng xuất" trong Trang Chủ
        }

        public FormTrangChu()
        {
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

        }

        private void quảnLýSáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormQuanLySach formQuanLySach = new FormQuanLySach(toolStripStatusLabel1.Text);
            formQuanLySach.Show();
            this.Close();
        }

        private void quảnLýKệSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKeSach formQuanLyKeSach = new FormQuanLyKeSach(toolStripStatusLabel1.Text);
            formQuanLyKeSach.Show();
            this.Close(); // Đóng form Trang Chủ sau khi mở form Quản Lý Kệ Sách
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLythuThu formQuanLythuThu = new FormQuanLythuThu(toolStripStatusLabel1.Text);
            formQuanLythuThu.Show();
            this.Close(); // Đóng form Trang Chủ sau khi mở form Quản Lý Thủ Thư
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyTacGia formQuanLyTacGia = new FormQuanLyTacGia(toolStripStatusLabel1.Text);
            formQuanLyTacGia.Show();
            this.Close(); // Đóng form Trang Chủ sau khi mở form Quản Lý Tác Giả
        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyPhieuMuon formQuanLyPhieuMuon = new FormQuanLyPhieuMuon(toolStripStatusLabel1.Text);
            formQuanLyPhieuMuon.Show();
            this.Close(); // Đóng form Trang Chủ sau khi mở form Quản Lý Phiếu Mượn
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
