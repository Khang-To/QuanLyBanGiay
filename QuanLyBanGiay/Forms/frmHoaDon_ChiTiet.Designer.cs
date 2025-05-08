namespace QuanLyBanGiay.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnKhachHangMoi = new Button();
            txtGhiChuHoaDon = new TextBox();
            label3 = new Label();
            cboKhachHang = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            lblSoLuongTonKho = new Label();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            cboLoaiGiay = new ComboBox();
            label9 = new Label();
            cboSize = new ComboBox();
            label6 = new Label();
            cboMauSac = new ComboBox();
            lblSoLuongHienTai = new Label();
            label8 = new Label();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            cboGiay = new ComboBox();
            label4 = new Label();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            panel2 = new Panel();
            lblTongTien = new Label();
            label12 = new Label();
            btnInHoaDon = new Button();
            btnLuu = new Button();
            SizeGiayID = new DataGridViewTextBoxColumn();
            TenGiay = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            GiayID = new DataGridViewTextBoxColumn();
            colSize = new DataGridViewTextBoxColumn();
            MauSacID = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhachHangMoi);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 111);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn:";
            // 
            // btnKhachHangMoi
            // 
            btnKhachHangMoi.Anchor = AnchorStyles.Top;
            btnKhachHangMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhachHangMoi.Location = new Point(662, 59);
            btnKhachHangMoi.Name = "btnKhachHangMoi";
            btnKhachHangMoi.Size = new Size(148, 39);
            btnKhachHangMoi.TabIndex = 6;
            btnKhachHangMoi.Text = "KHÁCH HÀNG MỚI...";
            btnKhachHangMoi.UseVisualStyleBackColor = true;
            btnKhachHangMoi.Click += btnKhachHangMoi_Click;
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.Top;
            txtGhiChuHoaDon.Location = new Point(112, 71);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(414, 23);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(8, 74);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.Top;
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(532, 30);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(278, 23);
            cboKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(453, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.Top;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(112, 30);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(276, 23);
            cboNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(14, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 468);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SizeGiayID, TenGiay, DonGiaBan, SoLuongBan, ThanhTien, GiayID, colSize, MauSacID });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 130);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(819, 285);
            dataGridView.TabIndex = 2;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSoLuongTonKho);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cboLoaiGiay);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cboSize);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboMauSac);
            panel1.Controls.Add(lblSoLuongHienTai);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(numDonGiaBan);
            panel1.Controls.Add(numSoLuongBan);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cboGiay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnXacNhanBan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 111);
            panel1.TabIndex = 0;
            // 
            // lblSoLuongTonKho
            // 
            lblSoLuongTonKho.Anchor = AnchorStyles.Top;
            lblSoLuongTonKho.AutoSize = true;
            lblSoLuongTonKho.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSoLuongTonKho.ForeColor = Color.Red;
            lblSoLuongTonKho.Location = new Point(606, 32);
            lblSoLuongTonKho.Name = "lblSoLuongTonKho";
            lblSoLuongTonKho.Size = new Size(15, 17);
            lblSoLuongTonKho.TabIndex = 30;
            lblSoLuongTonKho.Text = "0";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Location = new Point(478, 59);
            label14.Name = "label14";
            label14.Size = new Size(122, 15);
            label14.TabIndex = 29;
            label14.Text = "Số lượng tồn sau bán:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(5, 10);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 28;
            label11.Text = "Lọc theo:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(71, 10);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 27;
            label10.Text = "Loại giày:";
            // 
            // cboLoaiGiay
            // 
            cboLoaiGiay.Anchor = AnchorStyles.Top;
            cboLoaiGiay.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiGiay.FormattingEnabled = true;
            cboLoaiGiay.Location = new Point(134, 7);
            cboLoaiGiay.Name = "cboLoaiGiay";
            cboLoaiGiay.Size = new Size(121, 23);
            cboLoaiGiay.TabIndex = 26;
            cboLoaiGiay.SelectionChangeCommitted += cboLoaiGiay_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(450, 10);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 25;
            label9.Text = "Size";
            // 
            // cboSize
            // 
            cboSize.Anchor = AnchorStyles.Top;
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(483, 7);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(84, 23);
            cboSize.TabIndex = 24;
            cboSize.SelectionChangeCommitted += cboSize_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(287, 10);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 23;
            label6.Text = "Màu:";
            // 
            // cboMauSac
            // 
            cboMauSac.Anchor = AnchorStyles.Top;
            cboMauSac.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMauSac.FormattingEnabled = true;
            cboMauSac.Location = new Point(327, 7);
            cboMauSac.Name = "cboMauSac";
            cboMauSac.Size = new Size(84, 23);
            cboMauSac.TabIndex = 22;
            cboMauSac.SelectionChangeCommitted += cboMauSac_SelectionChangeCommitted;
            // 
            // lblSoLuongHienTai
            // 
            lblSoLuongHienTai.Anchor = AnchorStyles.Top;
            lblSoLuongHienTai.AutoSize = true;
            lblSoLuongHienTai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSoLuongHienTai.ForeColor = Color.Blue;
            lblSoLuongHienTai.Location = new Point(606, 57);
            lblSoLuongHienTai.Name = "lblSoLuongHienTai";
            lblSoLuongHienTai.Size = new Size(15, 17);
            lblSoLuongHienTai.TabIndex = 21;
            lblSoLuongHienTai.Text = "0";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(480, 34);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 20;
            label8.Text = "Số lượng tồn hiện tại:";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Anchor = AnchorStyles.Top;
            numDonGiaBan.Location = new Point(431, 77);
            numDonGiaBan.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(120, 23);
            numDonGiaBan.TabIndex = 19;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Anchor = AnchorStyles.Top;
            numSoLuongBan.Location = new Point(215, 77);
            numSoLuongBan.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(120, 23);
            numSoLuongBan.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(152, 79);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 13;
            label7.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(374, 79);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Đơn giá:";
            // 
            // cboGiay
            // 
            cboGiay.Anchor = AnchorStyles.Top;
            cboGiay.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGiay.FormattingEnabled = true;
            cboGiay.Location = new Point(48, 41);
            cboGiay.Name = "cboGiay";
            cboGiay.Size = new Size(399, 23);
            cboGiay.TabIndex = 10;
            cboGiay.SelectionChangeCommitted += cboGiay_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(9, 44);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Giày:";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(659, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(148, 39);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.Top;
            btnXacNhanBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhanBan.ForeColor = Color.Green;
            btnXacNhanBan.Location = new Point(659, 10);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(148, 39);
            btnXacNhanBan.TabIndex = 7;
            btnXacNhanBan.Text = "XÁC NHẬN BÁN";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnLuu);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(819, 50);
            panel2.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Blue;
            lblTongTien.Location = new Point(621, 16);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(48, 17);
            lblTongTien.TabIndex = 12;
            lblTongTien.Text = "0 VND";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(549, 16);
            label12.Name = "label12";
            label12.Size = new Size(66, 17);
            label12.TabIndex = 11;
            label12.Text = "Tổng tiền:";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInHoaDon.Location = new Point(225, 6);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(148, 39);
            btnInHoaDon.TabIndex = 10;
            btnInHoaDon.Text = "IN HÓA ĐƠN...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(71, 6);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(148, 39);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "LƯU HÓA ĐƠN";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // SizeGiayID
            // 
            SizeGiayID.DataPropertyName = "SizeGiayID";
            SizeGiayID.HeaderText = "ID";
            SizeGiayID.Name = "SizeGiayID";
            SizeGiayID.ReadOnly = true;
            SizeGiayID.Visible = false;
            // 
            // TenGiay
            // 
            TenGiay.DataPropertyName = "TenGiay";
            TenGiay.HeaderText = "Tên giày";
            TenGiay.Name = "TenGiay";
            TenGiay.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn giá";
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            SoLuongBan.HeaderText = "Số lượng";
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Green;
            dataGridViewCellStyle2.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // GiayID
            // 
            GiayID.DataPropertyName = "GiayID";
            GiayID.HeaderText = "Column1";
            GiayID.Name = "GiayID";
            GiayID.ReadOnly = true;
            GiayID.Visible = false;
            // 
            // colSize
            // 
            colSize.DataPropertyName = "Size";
            colSize.HeaderText = "Column1";
            colSize.Name = "colSize";
            colSize.ReadOnly = true;
            colSize.Visible = false;
            // 
            // MauSacID
            // 
            MauSacID.DataPropertyName = "MauSacID";
            MauSacID.HeaderText = "Column1";
            MauSacID.Name = "MauSacID";
            MauSacID.ReadOnly = true;
            MauSacID.Visible = false;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 579);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(841, 618);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGhiChuHoaDon;
        private Label label3;
        private ComboBox cboKhachHang;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label1;
        private Button btnKhachHangMoi;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Panel panel2;
        private Panel panel1;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private Button btnInHoaDon;
        private Button btnLuu;
        private NumericUpDown numSoLuongBan;
        private Label label7;
        private Label label5;
        private ComboBox cboGiay;
        private Label label4;
        private NumericUpDown numDonGiaBan;
        private Label lblSoLuongHienTai;
        private Label label8;
        private Label label9;
        private ComboBox cboSize;
        private Label label6;
        private ComboBox cboMauSac;
        private Label label10;
        private ComboBox cboLoaiGiay;
        private Label label11;
        private Label label12;
        private Label lblTongTien;
        private Label lblSoLuongTonKho;
        private Label label14;
        private DataGridViewTextBoxColumn SizeGiayID;
        private DataGridViewTextBoxColumn TenGiay;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn GiayID;
        private DataGridViewTextBoxColumn colSize;
        private DataGridViewTextBoxColumn MauSacID;
    }
}