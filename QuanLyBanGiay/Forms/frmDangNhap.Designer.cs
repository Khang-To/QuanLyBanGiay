namespace QuanLyBanGiay.Forms
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(26, 105);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Top;
            txtTenDangNhap.Location = new Point(107, 50);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(255, 23);
            txtTenDangNhap.TabIndex = 3;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top;
            txtMatKhau.Location = new Point(107, 102);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(255, 23);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.Top;
            btnDangNhap.BackColor = Color.Green;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.Control;
            btnDangNhap.Location = new Point(146, 147);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(105, 35);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = SystemColors.Control;
            btnHuyBo.Location = new Point(257, 147);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(105, 35);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "HỦY BỎ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://maithiencan.github.io/helpqlbg/dangnhap.html";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 195);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            helpProvider1.SetHelpKeyword(this, "F1");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDangNhap;
        private Button btnHuyBo;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
        private HelpProvider helpProvider1;
    }
}