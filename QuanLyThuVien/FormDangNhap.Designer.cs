namespace QuanLyThuVien
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonLinkLabel1 = new Krypton.Toolkit.KryptonLinkLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(322, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(207, 33);
            txtUsername.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 128);
            txtUsername.StateCommon.Border.Color2 = Color.Lime;
            txtUsername.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            txtUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUsername.StateCommon.Border.Rounding = 10F;
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(322, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(207, 33);
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 128);
            txtPassword.StateCommon.Border.Color2 = Color.Lime;
            txtPassword.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            txtPassword.StateCommon.Border.Rounding = 10F;
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(375, 310);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(107, 31);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255);
            kryptonButton1.StateCommon.Back.Color2 = Color.Aqua;
            kryptonButton1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear25;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 255);
            kryptonButton1.StateCommon.Border.Color2 = Color.Aqua;
            kryptonButton1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear25;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.Yellow;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(128, 255, 128);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(192, 255, 192);
            kryptonButton1.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Login";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonLinkLabel1
            // 
            kryptonLinkLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.ItalicPanel;
            kryptonLinkLabel1.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            kryptonLinkLabel1.Location = new Point(429, 280);
            kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            kryptonLinkLabel1.Size = new Size(123, 24);
            kryptonLinkLabel1.StateCommon.LongText.Color1 = Color.Transparent;
            kryptonLinkLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLinkLabel1.TabIndex = 6;
            kryptonLinkLabel1.Values.Text = "Quên mật khẩu?";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(229, 247);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(84, 27);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(255, 255, 192);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Password";
            kryptonLabel2.Click += kryptonLabel2_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(229, 203);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(86, 27);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(255, 255, 128);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Username";
            kryptonLabel1.Click += kryptonLabel1_Click;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(356, 134);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(98, 48);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Monotype Corsiva", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 7;
            kryptonLabel3.Values.Text = "Login";
            kryptonLabel3.Click += kryptonLabel3_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(486, 371);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(90, 31);
            kryptonButton2.StateCommon.Back.Color1 = Color.Red;
            kryptonButton2.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButton2.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton2.StateCommon.Border.Color1 = Color.Red;
            kryptonButton2.StateCommon.Border.Color2 = Color.IndianRed;
            kryptonButton2.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton2.StateCommon.Border.Rounding = 10F;
            kryptonButton2.StateCommon.Content.LongText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.LongText.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Monotype Corsiva", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonButton2.StateTracking.Back.Color1 = Color.FromArgb(255, 224, 192);
            kryptonButton2.StateTracking.Back.Color2 = Color.FromArgb(255, 255, 192);
            kryptonButton2.StateTracking.Content.ShortText.Color1 = Color.Red;
            kryptonButton2.StateTracking.Content.ShortText.Color2 = Color.FromArgb(255, 192, 192);
            kryptonButton2.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton2.TabIndex = 8;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Exit";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 434);
            ControlBox = false;
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLinkLabel1);
            Controls.Add(kryptonButton1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Name = "FormDangNhap";
            Text = "Đăng nhập ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
