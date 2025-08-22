namespace QuanLyThuVien
{
    partial class FormQuanLyDocGia
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
            txtboxMaDocGia = new Krypton.Toolkit.KryptonTextBox();
            txtBoxSoDienThoai = new Krypton.Toolkit.KryptonTextBox();
            txtBoxHoDocGia = new Krypton.Toolkit.KryptonTextBox();
            cbbDiaChi = new Krypton.Toolkit.KryptonComboBox();
            txtboxTenDocGia = new Krypton.Toolkit.KryptonTextBox();
            richTxtBoxGhiChu = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            btnThem = new Krypton.Toolkit.KryptonButton();
            btnSua = new Krypton.Toolkit.KryptonButton();
            btnXoa = new Krypton.Toolkit.KryptonButton();
            btnTimKiem = new Krypton.Toolkit.KryptonButton();
            btnThoat = new Krypton.Toolkit.KryptonButton();
            txtBoxTimKiem = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            DataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)cbbDiaChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtboxMaDocGia
            // 
            txtboxMaDocGia.Location = new Point(237, 147);
            txtboxMaDocGia.Name = "txtboxMaDocGia";
            txtboxMaDocGia.Size = new Size(125, 27);
            txtboxMaDocGia.StateCommon.Back.Color1 = Color.White;
            txtboxMaDocGia.TabIndex = 0;
            // 
            // txtBoxSoDienThoai
            // 
            txtBoxSoDienThoai.Location = new Point(565, 209);
            txtBoxSoDienThoai.Name = "txtBoxSoDienThoai";
            txtBoxSoDienThoai.Size = new Size(125, 27);
            txtBoxSoDienThoai.TabIndex = 1;
            // 
            // txtBoxHoDocGia
            // 
            txtBoxHoDocGia.Location = new Point(237, 209);
            txtBoxHoDocGia.Name = "txtBoxHoDocGia";
            txtBoxHoDocGia.Size = new Size(125, 27);
            txtBoxHoDocGia.StateCommon.Back.Color1 = Color.White;
            txtBoxHoDocGia.TabIndex = 2;
            // 
            // cbbDiaChi
            // 
            cbbDiaChi.DropDownWidth = 125;
            cbbDiaChi.Location = new Point(565, 147);
            cbbDiaChi.Name = "cbbDiaChi";
            cbbDiaChi.Size = new Size(125, 26);
            cbbDiaChi.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbbDiaChi.TabIndex = 3;
            cbbDiaChi.Text = "Chọn  địa chỉ";
            // 
            // txtboxTenDocGia
            // 
            txtboxTenDocGia.Location = new Point(237, 290);
            txtboxTenDocGia.Name = "txtboxTenDocGia";
            txtboxTenDocGia.Size = new Size(125, 27);
            txtboxTenDocGia.StateCommon.Back.Color1 = Color.White;
            txtboxTenDocGia.TabIndex = 4;
            txtboxTenDocGia.TextChanged += kryptonTextBox4_TextChanged;
            // 
            // richTxtBoxGhiChu
            // 
            richTxtBoxGhiChu.Location = new Point(565, 252);
            richTxtBoxGhiChu.Name = "richTxtBoxGhiChu";
            richTxtBoxGhiChu.Size = new Size(125, 65);
            richTxtBoxGhiChu.TabIndex = 5;
            richTxtBoxGhiChu.Text = "";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(128, 147);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(88, 22);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel1.TabIndex = 6;
            kryptonLabel1.Values.Text = "Mã độc giả";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(128, 209);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(87, 22);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel2.TabIndex = 7;
            kryptonLabel2.Values.Text = "Họ độc giả";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(128, 293);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(93, 22);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel3.TabIndex = 8;
            kryptonLabel3.Values.Text = "Tên độc giả";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(422, 150);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(6, 2);
            kryptonLabel4.TabIndex = 9;
            kryptonLabel4.Values.Text = "";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(460, 150);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(61, 22);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel5.TabIndex = 10;
            kryptonLabel5.Values.Text = "Địa chỉ";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(460, 293);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(66, 22);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel6.TabIndex = 11;
            kryptonLabel6.Values.Text = "Ghi chú";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(322, 61);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(321, 49);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.MidnightBlue;
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Georgia", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 12;
            kryptonLabel7.Values.Text = "Quản lý độc giả";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(460, 212);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(105, 22);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel8.TabIndex = 13;
            kryptonLabel8.Values.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(128, 348);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 31);
            btnThem.StateCommon.Back.Color1 = Color.MediumSeaGreen;
            btnThem.StateCommon.Border.Rounding = 10F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            btnThem.TabIndex = 14;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(280, 348);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 31);
            btnSua.StateCommon.Back.Color1 = Color.Goldenrod;
            btnSua.StateCommon.Border.Rounding = 10F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            btnSua.TabIndex = 15;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(433, 348);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 31);
            btnXoa.StateCommon.Back.Color1 = Color.IndianRed;
            btnXoa.StateCommon.Border.Rounding = 10F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            btnXoa.TabIndex = 16;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(795, 348);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 31);
            btnTimKiem.StateCommon.Back.Color1 = Color.SteelBlue;
            btnTimKiem.StateCommon.Border.Rounding = 10F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(578, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 31);
            btnThoat.StateCommon.Back.Color1 = Color.SlateGray;
            btnThoat.StateCommon.Border.Rounding = 10F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Italic);
            btnThoat.TabIndex = 18;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            // 
            // txtBoxTimKiem
            // 
            txtBoxTimKiem.Location = new Point(781, 304);
            txtBoxTimKiem.Name = "txtBoxTimKiem";
            txtBoxTimKiem.Size = new Size(140, 27);
            txtBoxTimKiem.TabIndex = 19;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(795, 274);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(88, 22);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 20;
            kryptonLabel9.Values.Text = "Mã độc giả";
            // 
            // DataGridView1
            // 
            DataGridView1.BorderStyle = BorderStyle.None;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(-6, 402);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(940, 188);
            DataGridView1.TabIndex = 21;
            // 
            // FormQuanLyDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(933, 489);
            Controls.Add(DataGridView1);
            Controls.Add(kryptonLabel9);
            Controls.Add(txtBoxTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(richTxtBoxGhiChu);
            Controls.Add(txtboxTenDocGia);
            Controls.Add(cbbDiaChi);
            Controls.Add(txtBoxHoDocGia);
            Controls.Add(txtBoxSoDienThoai);
            Controls.Add(txtboxMaDocGia);
            ForeColor = Color.Black;
            Name = "FormQuanLyDocGia";
            Text = "FormQuanLyDocGia";
            ((System.ComponentModel.ISupportInitialize)cbbDiaChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtboxMaDocGia;
        private Krypton.Toolkit.KryptonTextBox txtBoxSoDienThoai;
        private Krypton.Toolkit.KryptonTextBox txtBoxHoDocGia;
        private Krypton.Toolkit.KryptonComboBox cbbDiaChi;
        private Krypton.Toolkit.KryptonTextBox txtboxTenDocGia;
        private Krypton.Toolkit.KryptonRichTextBox richTxtBoxGhiChu;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnTimKiem;
        private Krypton.Toolkit.KryptonButton btnThoat;
        private Krypton.Toolkit.KryptonTextBox txtBoxTimKiem;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonDataGridView DataGridView1;
    }
}