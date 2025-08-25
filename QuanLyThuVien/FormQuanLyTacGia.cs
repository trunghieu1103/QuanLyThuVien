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
    public partial class FormQuanLyTacGia : Form
    {
        public FormQuanLyTacGia(string username)
        {
            InitializeComponent();
            label1.Text = username;
            label1.Hide();
        }
        private void FormQuanLyTacGia_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private async void kryptonButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) {
                FormTrangChu formTrangChu = new FormTrangChu(label1.Text);
                await Task.Delay(500); // Giả lập thời gian thoát
                formTrangChu.Show();
                this.Close();

            }
        }
    }
}
