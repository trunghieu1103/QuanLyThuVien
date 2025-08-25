namespace QuanLyThuVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            kryptonButton1.Text = "Đang đăng nhập ...";
            await Task.Delay(500); // Giả lập thời gian đăng nhập
            string username = txtUsername.Text.Trim();
            FormTrangChu formTrangChu = new FormTrangChu(username);
            
            formTrangChu.ShowDialog();
            this.Hide(); // Ẩn form đăng nhập sau khi đăng nhập thành công
        }

        private async void kryptonButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát! ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                
                kryptonButton2.Text = "Đang thoát ...";

                await Task.Delay(500); // Giả lập thời gian thoát ứng dụng
                Application.Exit();
            }
            
        }
    }
}
