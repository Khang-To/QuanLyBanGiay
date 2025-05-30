namespace QuanLyBanGiay.Forms
{
    partial class frmDoiMatKhau
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
            btnHuyBo = new Button();
            btnDangNhap = new Button();
            txtMatKhauCu = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMatKhauMoi = new TextBox();
            label4 = new Label();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = SystemColors.Control;
            btnHuyBo.Location = new Point(259, 145);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(105, 35);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "HỦY BỎ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.Top;
            btnDangNhap.BackColor = Color.Green;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.Control;
            btnDangNhap.Location = new Point(148, 145);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(105, 35);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "ĐỔI MẬT KHẨU";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDoiMatKhau_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Anchor = AnchorStyles.Top;
            txtMatKhauCu.Location = new Point(109, 87);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(255, 23);
            txtMatKhauCu.TabIndex = 0;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Top;
            txtTenDangNhap.Location = new Point(109, 58);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(255, 23);
            txtTenDangNhap.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(27, 90);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 8;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 7;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Top;
            txtMatKhauMoi.Location = new Point(109, 116);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(255, 23);
            txtMatKhauMoi.TabIndex = 1;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(19, 119);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 14;
            label4.Text = "Mật khẩu mới:";
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://maithiencan.github.io/helpqlbg/doimatkhau.html";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 188);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label4);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            helpProvider1.SetHelpKeyword(this, "F1");
            Name = "frmDoiMatKhau";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuyBo;
        private Button btnDangNhap;
        public TextBox txtMatKhauCu;
        public TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtMatKhauMoi;
        private Label label4;
        private HelpProvider helpProvider1;
    }
}