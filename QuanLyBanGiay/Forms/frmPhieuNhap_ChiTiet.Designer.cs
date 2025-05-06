namespace QuanLyBanGiay.Forms
{
    partial class frmPhieuNhap_ChiTiet
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            txtGhiChuPhieuNhap = new TextBox();
            label2 = new Label();
            cboNhaCungCap = new ComboBox();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            btnXoa = new Button();
            btnXacNhanNhap = new Button();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            cboGiay = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cboLoaiGiay = new ComboBox();
            label7 = new Label();
            cboThuongHieu = new ComboBox();
            label8 = new Label();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            lblTongTien = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuPhieuNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboThuongHieu);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cboLoaiGiay);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanNhap);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(cboGiay);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1141, 414);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(btnLuuHoaDon);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 539);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 100);
            panel1.TabIndex = 2;
            // 
            // txtGhiChuPhieuNhap
            // 
            txtGhiChuPhieuNhap.Anchor = AnchorStyles.Top;
            txtGhiChuPhieuNhap.Location = new Point(247, 82);
            txtGhiChuPhieuNhap.Name = "txtGhiChuPhieuNhap";
            txtGhiChuPhieuNhap.Size = new Size(790, 27);
            txtGhiChuPhieuNhap.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(99, 85);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 31;
            label2.Text = "Ghi chú phiếu nhập:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Anchor = AnchorStyles.Top;
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(749, 33);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(288, 28);
            cboNhaCungCap.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(617, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 30;
            label1.Text = "Nhà cung cấp (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.Top;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(247, 33);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(295, 28);
            cboNhanVien.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(115, 36);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 29;
            label3.Text = "Nhân viên lập (*):";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(943, 123);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanNhap
            // 
            btnXacNhanNhap.Anchor = AnchorStyles.Top;
            btnXacNhanNhap.Location = new Point(793, 124);
            btnXacNhanNhap.Name = "btnXacNhanNhap";
            btnXacNhanNhap.Size = new Size(131, 29);
            btnXacNhanNhap.TabIndex = 12;
            btnXacNhanNhap.Text = "Xác nhận nhập";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Anchor = AnchorStyles.Top;
            numDonGiaBan.Location = new Point(953, 58);
            numDonGiaBan.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(150, 27);
            numDonGiaBan.TabIndex = 11;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Anchor = AnchorStyles.Top;
            numSoLuongBan.Location = new Point(763, 58);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(150, 27);
            numSoLuongBan.TabIndex = 10;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // cboGiay
            // 
            cboGiay.Anchor = AnchorStyles.Top;
            cboGiay.FormattingEnabled = true;
            cboGiay.Location = new Point(129, 123);
            cboGiay.Name = "cboGiay";
            cboGiay.Size = new Size(581, 28);
            cboGiay.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(953, 26);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 16;
            label6.Text = "Đơn giá nhập (*):";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(763, 26);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 15;
            label5.Text = "Số lượng nhập (*):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 14;
            label4.Text = "Giày (*):";
            label4.Click += label4_Click;
            // 
            // cboLoaiGiay
            // 
            cboLoaiGiay.Anchor = AnchorStyles.Top;
            cboLoaiGiay.FormattingEnabled = true;
            cboLoaiGiay.Location = new Point(479, 55);
            cboLoaiGiay.Name = "cboLoaiGiay";
            cboLoaiGiay.Size = new Size(231, 28);
            cboLoaiGiay.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(381, 60);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 18;
            label7.Text = "Loại giày (*):";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.Anchor = AnchorStyles.Top;
            cboThuongHieu.FormattingEnabled = true;
            cboThuongHieu.Location = new Point(129, 55);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(231, 28);
            cboThuongHieu.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(6, 60);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 20;
            label8.Text = "Thương hiệu (*):";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Top;
            btnInHoaDon.Location = new Point(451, 39);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(119, 29);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "In phiếu nhập...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.Top;
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(311, 39);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(134, 29);
            btnLuuHoaDon.TabIndex = 2;
            btnLuuHoaDon.Text = "Lưu phiếu nhập";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(839, 43);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(96, 20);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền: 0đ";
            // 
            // frmPhieuNhap_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 639);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmPhieuNhap_ChiTiet";
            Text = "Chi tiết phiếu nhập";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private TextBox txtGhiChuPhieuNhap;
        private Label label2;
        private ComboBox cboNhaCungCap;
        private Label label1;
        private ComboBox cboNhanVien;
        private Label label3;
        private ComboBox cboThuongHieu;
        private Label label8;
        private ComboBox cboLoaiGiay;
        private Label label7;
        private Button btnXoa;
        private Button btnXacNhanNhap;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private ComboBox cboGiay;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblTongTien;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
    }
}