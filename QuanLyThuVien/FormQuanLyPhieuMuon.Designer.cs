namespace QuanLyThuVien
{
    partial class FormQuanLyPhieuMuon
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
            txtMaPhieuMuon = new Krypton.Toolkit.KryptonTextBox();
            txtBoxGhiChu = new Krypton.Toolkit.KryptonRichTextBox();
            dTPNgayMuon = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            btnThem = new Krypton.Toolkit.KryptonButton();
            btnSua = new Krypton.Toolkit.KryptonButton();
            btnXoa = new Krypton.Toolkit.KryptonButton();
            btnThoat = new Krypton.Toolkit.KryptonButton();
            txtBoxTimKiem = new Krypton.Toolkit.KryptonTextBox();
            btnTimKiem = new Krypton.Toolkit.KryptonButton();
            btnMaDocGia = new Krypton.Toolkit.KryptonComboBox();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnMaDocGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMaPhieuMuon
            // 
            txtMaPhieuMuon.Location = new Point(192, 163);
            txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            txtMaPhieuMuon.Size = new Size(125, 33);
            txtMaPhieuMuon.StateCommon.Border.Rounding = 10F;
            txtMaPhieuMuon.TabIndex = 0;
            // 
            // txtBoxGhiChu
            // 
            txtBoxGhiChu.Location = new Point(448, 163);
            txtBoxGhiChu.Name = "txtBoxGhiChu";
            txtBoxGhiChu.Size = new Size(125, 126);
            txtBoxGhiChu.StateCommon.Border.Rounding = 10F;
            txtBoxGhiChu.TabIndex = 2;
            txtBoxGhiChu.Text = "";
            // 
            // dTPNgayMuon
            // 
            dTPNgayMuon.Location = new Point(192, 258);
            dTPNgayMuon.Name = "dTPNgayMuon";
            dTPNgayMuon.Size = new Size(125, 31);
            dTPNgayMuon.StateNormal.Border.Rounding = 10F;
            dTPNgayMuon.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(33, 172);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(153, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "Mã phiếu mượn ";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(40, 219);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(110, 24);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Mã độc giả";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(40, 265);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(116, 24);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel3.TabIndex = 6;
            kryptonLabel3.Values.Text = "Ngày mượn";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(360, 172);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(82, 24);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel4.TabIndex = 7;
            kryptonLabel4.Values.Text = "Ghi chú";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(159, 50);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(414, 49);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.DarkSlateBlue;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(255, 192, 192);
            kryptonLabel5.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Georgia", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 8;
            kryptonLabel5.Values.Text = "Quản lý phiếu mượn";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(60, 306);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 31);
            btnThem.StateCommon.Back.Color1 = Color.MediumSeaGreen;
            btnThem.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 192);
            btnThem.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            btnThem.StateCommon.Border.Rounding = 10F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnThem.TabIndex = 9;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(189, 306);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 31);
            btnSua.StateCommon.Back.Color1 = Color.Goldenrod;
            btnSua.StateCommon.Back.Color2 = Color.FromArgb(255, 224, 192);
            btnSua.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            btnSua.StateCommon.Border.Rounding = 10F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnSua.TabIndex = 10;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(318, 306);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 31);
            btnXoa.StateCommon.Back.Color1 = Color.IndianRed;
            btnXoa.StateCommon.Back.Color2 = Color.FromArgb(255, 192, 192);
            btnXoa.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            btnXoa.StateCommon.Border.Rounding = 10F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnXoa.TabIndex = 11;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(448, 306);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 31);
            btnThoat.StateCommon.Back.Color1 = Color.SlateGray;
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(224, 224, 224);
            btnThoat.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            btnThoat.StateCommon.Border.Rounding = 10F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnThoat.TabIndex = 12;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // txtBoxTimKiem
            // 
            txtBoxTimKiem.Location = new Point(647, 258);
            txtBoxTimKiem.Name = "txtBoxTimKiem";
            txtBoxTimKiem.Size = new Size(139, 33);
            txtBoxTimKiem.StateCommon.Border.Rounding = 10F;
            txtBoxTimKiem.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(662, 306);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 31);
            btnTimKiem.StateCommon.Back.Color1 = Color.SteelBlue;
            btnTimKiem.StateCommon.Back.Color2 = Color.FromArgb(192, 255, 255);
            btnTimKiem.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            btnTimKiem.StateCommon.Border.Rounding = 10F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnMaDocGia
            // 
            btnMaDocGia.DropDownWidth = 119;
            btnMaDocGia.Location = new Point(192, 211);
            btnMaDocGia.Name = "btnMaDocGia";
            btnMaDocGia.Size = new Size(125, 32);
            btnMaDocGia.StateCommon.ComboBox.Border.Rounding = 10F;
            btnMaDocGia.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnMaDocGia.StateCommon.Item.Border.Rounding = 10F;
            btnMaDocGia.TabIndex = 15;
            btnMaDocGia.Text = "Chọn mã độc giả";
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(633, 227);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(153, 24);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel6.TabIndex = 16;
            kryptonLabel6.Values.Text = "Mã phiếu mượn ";
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Location = new Point(2, 364);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.Size = new Size(851, 188);
            kryptonDataGridView1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_Đại_học_Bách_Khoa_Hà_Nội_svg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(695, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 160);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(736, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 19;
            // 
            // FormQuanLyPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(808, 475);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(kryptonLabel6);
            Controls.Add(btnMaDocGia);
            Controls.Add(btnTimKiem);
            Controls.Add(txtBoxTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(dTPNgayMuon);
            Controls.Add(txtBoxGhiChu);
            Controls.Add(txtMaPhieuMuon);
            Name = "FormQuanLyPhieuMuon";
            Text = "FormQuanLyPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)btnMaDocGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtMaPhieuMuon;
        private Krypton.Toolkit.KryptonRichTextBox txtBoxGhiChu;
        private Krypton.Toolkit.KryptonDateTimePicker dTPNgayMuon;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnThoat;
        private Krypton.Toolkit.KryptonTextBox txtBoxTimKiem;
        private Krypton.Toolkit.KryptonButton btnTimKiem;
        private Krypton.Toolkit.KryptonComboBox btnMaDocGia;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}