namespace QuanLyThuVien
{
    partial class FormQuanLySach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxMaSach = new Krypton.Toolkit.KryptonTextBox();
            txtboxTenSach = new Krypton.Toolkit.KryptonTextBox();
            cbboxTheLoai = new Krypton.Toolkit.KryptonComboBox();
            cbboxTacGia = new Krypton.Toolkit.KryptonComboBox();
            txtDonGia = new Krypton.Toolkit.KryptonTextBox();
            cbbMaKe = new Krypton.Toolkit.KryptonComboBox();
            cbboxNhaXuatBan = new Krypton.Toolkit.KryptonComboBox();
            txtBoxNamXuatBan = new Krypton.Toolkit.KryptonTextBox();
            txtBoxSoLuongSach = new Krypton.Toolkit.KryptonTextBox();
            txtBoxGhiChu = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            dataGridView1 = new DataGridView();
            btnThem = new Krypton.Toolkit.KryptonButton();
            btnXoa = new Krypton.Toolkit.KryptonButton();
            btnSua = new Krypton.Toolkit.KryptonButton();
            btnTimKiem = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            btnThoat = new Krypton.Toolkit.KryptonButton();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cbboxTheLoai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbboxTacGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbbMaKe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbboxNhaXuatBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtboxMaSach
            // 
            txtboxMaSach.Location = new Point(249, 97);
            txtboxMaSach.Name = "txtboxMaSach";
            txtboxMaSach.Size = new Size(125, 33);
            txtboxMaSach.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtboxMaSach.StateCommon.Border.Color1 = Color.LightGray;
            txtboxMaSach.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtboxMaSach.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtboxMaSach.StateCommon.Border.Rounding = 10F;
            txtboxMaSach.TabIndex = 0;
            // 
            // txtboxTenSach
            // 
            txtboxTenSach.Location = new Point(622, 97);
            txtboxTenSach.Name = "txtboxTenSach";
            txtboxTenSach.Size = new Size(125, 33);
            txtboxTenSach.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtboxTenSach.StateCommon.Border.Color1 = Color.LightGray;
            txtboxTenSach.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtboxTenSach.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtboxTenSach.StateCommon.Border.Rounding = 10F;
            txtboxTenSach.TabIndex = 1;
            // 
            // cbboxTheLoai
            // 
            cbboxTheLoai.DropDownWidth = 125;
            cbboxTheLoai.Location = new Point(249, 153);
            cbboxTheLoai.Name = "cbboxTheLoai";
            cbboxTheLoai.Size = new Size(125, 27);
            cbboxTheLoai.StateCommon.ComboBox.Back.Color1 = Color.White;
            cbboxTheLoai.StateCommon.ComboBox.Border.Color1 = Color.LightGray;
            cbboxTheLoai.StateCommon.ComboBox.Border.Rounding = 10F;
            cbboxTheLoai.StateCommon.ComboBox.Content.Font = new Font("Georgia", 7.8F, FontStyle.Italic);
            cbboxTheLoai.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbboxTheLoai.StateCommon.DropBack.Color1 = Color.White;
            cbboxTheLoai.StateCommon.Item.Border.Color1 = Color.FromArgb(128, 255, 255);
            cbboxTheLoai.StateCommon.Item.Border.Rounding = 10F;
            cbboxTheLoai.TabIndex = 2;
            cbboxTheLoai.Text = "Chọn thể loại";
            // 
            // cbboxTacGia
            // 
            cbboxTacGia.DropDownWidth = 125;
            cbboxTacGia.Location = new Point(249, 208);
            cbboxTacGia.Name = "cbboxTacGia";
            cbboxTacGia.Size = new Size(125, 27);
            cbboxTacGia.StateCommon.ComboBox.Back.Color1 = Color.White;
            cbboxTacGia.StateCommon.ComboBox.Border.Color1 = Color.LightGray;
            cbboxTacGia.StateCommon.ComboBox.Border.Rounding = 10F;
            cbboxTacGia.StateCommon.ComboBox.Content.Font = new Font("Georgia", 7.8F, FontStyle.Italic);
            cbboxTacGia.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbboxTacGia.TabIndex = 3;
            cbboxTacGia.Text = "Chọn tác giả";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(622, 153);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 33);
            txtDonGia.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtDonGia.StateCommon.Border.Color1 = Color.LightGray;
            txtDonGia.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtDonGia.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtDonGia.StateCommon.Border.Rounding = 10F;
            txtDonGia.TabIndex = 4;
            // 
            // cbbMaKe
            // 
            cbbMaKe.DropDownWidth = 125;
            cbbMaKe.Location = new Point(249, 311);
            cbbMaKe.Name = "cbbMaKe";
            cbbMaKe.Size = new Size(125, 27);
            cbbMaKe.StateCommon.ComboBox.Back.Color1 = Color.White;
            cbbMaKe.StateCommon.ComboBox.Border.Color1 = Color.LightGray;
            cbbMaKe.StateCommon.ComboBox.Border.Rounding = 10F;
            cbbMaKe.StateCommon.ComboBox.Content.Font = new Font("Georgia", 7.8F, FontStyle.Italic);
            cbbMaKe.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbbMaKe.TabIndex = 5;
            cbbMaKe.Text = "Chọn mã kệ";
            // 
            // cbboxNhaXuatBan
            // 
            cbboxNhaXuatBan.DropDownWidth = 125;
            cbboxNhaXuatBan.Location = new Point(249, 262);
            cbboxNhaXuatBan.Name = "cbboxNhaXuatBan";
            cbboxNhaXuatBan.Size = new Size(125, 27);
            cbboxNhaXuatBan.StateCommon.ComboBox.Back.Color1 = Color.White;
            cbboxNhaXuatBan.StateCommon.ComboBox.Border.Color1 = Color.LightGray;
            cbboxNhaXuatBan.StateCommon.ComboBox.Border.Rounding = 10F;
            cbboxNhaXuatBan.StateCommon.ComboBox.Content.Font = new Font("Georgia", 7.8F, FontStyle.Italic);
            cbboxNhaXuatBan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbboxNhaXuatBan.TabIndex = 6;
            cbboxNhaXuatBan.Text = "Chọn nhà xuất bản";
            // 
            // txtBoxNamXuatBan
            // 
            txtBoxNamXuatBan.Location = new Point(622, 255);
            txtBoxNamXuatBan.Name = "txtBoxNamXuatBan";
            txtBoxNamXuatBan.Size = new Size(125, 33);
            txtBoxNamXuatBan.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtBoxNamXuatBan.StateCommon.Border.Color1 = Color.LightGray;
            txtBoxNamXuatBan.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtBoxNamXuatBan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtBoxNamXuatBan.StateCommon.Border.Rounding = 10F;
            txtBoxNamXuatBan.TabIndex = 7;
            // 
            // txtBoxSoLuongSach
            // 
            txtBoxSoLuongSach.Location = new Point(622, 207);
            txtBoxSoLuongSach.Name = "txtBoxSoLuongSach";
            txtBoxSoLuongSach.Size = new Size(125, 33);
            txtBoxSoLuongSach.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtBoxSoLuongSach.StateCommon.Border.Color1 = Color.LightGray;
            txtBoxSoLuongSach.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtBoxSoLuongSach.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtBoxSoLuongSach.StateCommon.Border.Rounding = 10F;
            txtBoxSoLuongSach.TabIndex = 8;
            // 
            // txtBoxGhiChu
            // 
            txtBoxGhiChu.Location = new Point(622, 303);
            txtBoxGhiChu.Name = "txtBoxGhiChu";
            txtBoxGhiChu.Size = new Size(125, 27);
            txtBoxGhiChu.StateCommon.Back.Color1 = Color.WhiteSmoke;
            txtBoxGhiChu.StateCommon.Border.Color1 = Color.LightGray;
            txtBoxGhiChu.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtBoxGhiChu.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            txtBoxGhiChu.StateCommon.Border.Rounding = 10F;
            txtBoxGhiChu.TabIndex = 10;
            txtBoxGhiChu.Text = "";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(132, 97);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(70, 21);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.Text = "Mã sách";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(507, 100);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(72, 21);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel2.TabIndex = 12;
            kryptonLabel2.Values.Text = "Tên sách";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(132, 208);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(63, 21);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel3.TabIndex = 13;
            kryptonLabel3.Values.Text = "Tác giả";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(132, 261);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(105, 21);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel4.TabIndex = 14;
            kryptonLabel4.Values.Text = "Nhà xuất bản";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(132, 308);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(55, 21);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel5.TabIndex = 15;
            kryptonLabel5.Values.Text = "Mã kệ ";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(132, 153);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(68, 21);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel6.TabIndex = 16;
            kryptonLabel6.Values.Text = "Thể loại";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(507, 156);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(67, 21);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel7.TabIndex = 17;
            kryptonLabel7.Values.Text = "Đơn giá ";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(507, 211);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(107, 21);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel8.TabIndex = 18;
            kryptonLabel8.Values.Text = "Số lượng sách";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(507, 261);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(110, 21);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel9.TabIndex = 19;
            kryptonLabel9.Values.Text = "Năm xuất bản";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(507, 311);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(64, 21);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            kryptonLabel10.TabIndex = 20;
            kryptonLabel10.Values.Text = "Ghi chú";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(346, 29);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(245, 44);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.FromArgb(192, 64, 0);
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.Red;
            kryptonLabel11.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel11.TabIndex = 21;
            kryptonLabel11.Values.Text = "Quản lý sách ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 414);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1001, 246);
            dataGridView1.TabIndex = 22;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(161, 355);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 31);
            btnThem.StateCommon.Back.Color1 = Color.MediumSeaGreen;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Italic);
            btnThem.TabIndex = 23;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm ";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(441, 355);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 31);
            btnXoa.StateCommon.Back.Color1 = Color.IndianRed;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Italic);
            btnXoa.TabIndex = 24;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(302, 355);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 31);
            btnSua.StateCommon.Back.Color1 = Color.Goldenrod;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Italic);
            btnSua.TabIndex = 25;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa";
            btnSua.Values.UseAsADialogButton = true;
            btnSua.Click += kryptonButton3_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(877, 355);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 31);
            btnTimKiem.StateCommon.Back.Color1 = Color.SteelBlue;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm ";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(763, 353);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(108, 33);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox1.StateCommon.Border.Color1 = Color.LightGray;
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonTextBox1.StateCommon.Border.Rounding = 10F;
            kryptonTextBox1.TabIndex = 27;
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(779, 323);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(78, 24);
            kryptonLabel12.StateCommon.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel12.TabIndex = 28;
            kryptonLabel12.Values.Text = "Mã sách";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(578, 355);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 31);
            btnThoat.StateCommon.Back.Color1 = Color.SlateGray;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Italic);
            btnThoat.TabIndex = 29;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += kryptonButton3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(947, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(16, 27);
            textBox1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Trung\\OneDrive\\Pictures\\Saved Pictures\\Logo_Đại_học_Bách_Khoa_Hà_Nội.svg.png";
            pictureBox1.Location = new Point(885, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // FormQuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1001, 610);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnThoat);
            Controls.Add(kryptonLabel12);
            Controls.Add(kryptonTextBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonLabel10);
            Controls.Add(kryptonLabel9);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtBoxGhiChu);
            Controls.Add(txtBoxSoLuongSach);
            Controls.Add(txtBoxNamXuatBan);
            Controls.Add(cbboxNhaXuatBan);
            Controls.Add(cbbMaKe);
            Controls.Add(txtDonGia);
            Controls.Add(cbboxTacGia);
            Controls.Add(cbboxTheLoai);
            Controls.Add(txtboxTenSach);
            Controls.Add(txtboxMaSach);
            Name = "FormQuanLySach";
            Text = "FormQuanLySach";
            ((System.ComponentModel.ISupportInitialize)cbboxTheLoai).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbboxTacGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbbMaKe).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbboxNhaXuatBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtboxMaSach;
        private Krypton.Toolkit.KryptonTextBox txtboxTenSach;
        private Krypton.Toolkit.KryptonComboBox cbboxTheLoai;
        private Krypton.Toolkit.KryptonComboBox cbboxTacGia;
        private Krypton.Toolkit.KryptonTextBox txtDonGia;
        private Krypton.Toolkit.KryptonComboBox cbbMaKe;
        private Krypton.Toolkit.KryptonComboBox cbboxNhaXuatBan;
        private Krypton.Toolkit.KryptonTextBox txtBoxNamXuatBan;
        private Krypton.Toolkit.KryptonTextBox txtBoxSoLuongSach;
        private Krypton.Toolkit.KryptonRichTextBox txtBoxGhiChu;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private DataGridView dataGridView1;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnTimKiem;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonButton btnThoat;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}