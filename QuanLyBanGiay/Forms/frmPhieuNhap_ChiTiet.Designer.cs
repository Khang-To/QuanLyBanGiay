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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuPhieuNhap = new TextBox();
            label2 = new Label();
            cboNhaCungCap = new ComboBox();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblLoaiGiay = new Label();
            lblThuongHieu = new Label();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            SizeGiayID = new DataGridViewTextBoxColumn();
            TenGiay = new DataGridViewTextBoxColumn();
            TenMau = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            numSizeGiay = new NumericUpDown();
            cboMauSac = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            btnXoa = new Button();
            btnXacNhanNhap = new Button();
            numDonGiaNhap = new NumericUpDown();
            numSoLuongNhap = new NumericUpDown();
            cboGiay = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblTongTien = new Label();
            btnInPhieuNhap = new Button();
            btnLuuPhieuNhap = new Button();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSizeGiay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).BeginInit();
            panel1.SuspendLayout();
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
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1000, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtGhiChuPhieuNhap
            // 
            txtGhiChuPhieuNhap.Anchor = AnchorStyles.Top;
            txtGhiChuPhieuNhap.Location = new Point(217, 62);
            txtGhiChuPhieuNhap.Margin = new Padding(3, 2, 3, 2);
            txtGhiChuPhieuNhap.Name = "txtGhiChuPhieuNhap";
            txtGhiChuPhieuNhap.Size = new Size(692, 23);
            txtGhiChuPhieuNhap.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(88, 64);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 31;
            label2.Text = "Ghi chú phiếu nhập:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Anchor = AnchorStyles.Top;
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(656, 25);
            cboNhaCungCap.Margin = new Padding(3, 2, 3, 2);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(252, 23);
            cboNhaCungCap.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(541, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 30;
            label1.Text = "Nhà cung cấp (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.Top;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(217, 25);
            cboNhanVien.Margin = new Padding(3, 2, 3, 2);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(259, 23);
            cboNhanVien.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(102, 27);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 29;
            label3.Text = "Nhân viên lập (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblLoaiGiay);
            groupBox2.Controls.Add(lblThuongHieu);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(numSizeGiay);
            groupBox2.Controls.Add(cboMauSac);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanNhap);
            groupBox2.Controls.Add(numDonGiaNhap);
            groupBox2.Controls.Add(numSoLuongNhap);
            groupBox2.Controls.Add(cboGiay);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 94);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1000, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // lblLoaiGiay
            // 
            lblLoaiGiay.AutoSize = true;
            lblLoaiGiay.Location = new Point(255, 93);
            lblLoaiGiay.Name = "lblLoaiGiay";
            lblLoaiGiay.Size = new Size(57, 15);
            lblLoaiGiay.TabIndex = 24;
            lblLoaiGiay.Text = "Loại giày:";
            // 
            // lblThuongHieu
            // 
            lblThuongHieu.AutoSize = true;
            lblThuongHieu.Location = new Point(18, 93);
            lblThuongHieu.Name = "lblThuongHieu";
            lblThuongHieu.Size = new Size(78, 15);
            lblThuongHieu.TabIndex = 23;
            lblThuongHieu.Text = "Thương hiệu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 144);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 170);
            panel2.TabIndex = 22;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SizeGiayID, TenGiay, TenMau, Size, SoLuongNhap, DonGiaNhap, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(994, 170);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // SizeGiayID
            // 
            SizeGiayID.DataPropertyName = "SizeGiayID";
            SizeGiayID.HeaderText = "ID";
            SizeGiayID.MinimumWidth = 6;
            SizeGiayID.Name = "SizeGiayID";
            SizeGiayID.ReadOnly = true;
            // 
            // TenGiay
            // 
            TenGiay.DataPropertyName = "TenGiay";
            TenGiay.HeaderText = "Tên giày";
            TenGiay.MinimumWidth = 6;
            TenGiay.Name = "TenGiay";
            TenGiay.ReadOnly = true;
            // 
            // TenMau
            // 
            TenMau.DataPropertyName = "TenMau";
            TenMau.HeaderText = "Màu sắc";
            TenMau.MinimumWidth = 6;
            TenMau.Name = "TenMau";
            TenMau.ReadOnly = true;
            // 
            // Size
            // 
            Size.DataPropertyName = "Size";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Size.DefaultCellStyle = dataGridViewCellStyle1;
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle3;
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.Blue;
            dataGridViewCellStyle4.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // numSizeGiay
            // 
            numSizeGiay.Anchor = AnchorStyles.Top;
            numSizeGiay.Location = new Point(517, 44);
            numSizeGiay.Margin = new Padding(3, 2, 3, 2);
            numSizeGiay.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            numSizeGiay.Minimum = new decimal(new int[] { 27, 0, 0, 0 });
            numSizeGiay.Name = "numSizeGiay";
            numSizeGiay.Size = new Size(131, 23);
            numSizeGiay.TabIndex = 21;
            numSizeGiay.ThousandsSeparator = true;
            numSizeGiay.Value = new decimal(new int[] { 27, 0, 0, 0 });
            // 
            // cboMauSac
            // 
            cboMauSac.Anchor = AnchorStyles.Top;
            cboMauSac.FormattingEnabled = true;
            cboMauSac.Location = new Point(351, 44);
            cboMauSac.Margin = new Padding(3, 2, 3, 2);
            cboMauSac.Name = "cboMauSac";
            cboMauSac.Size = new Size(125, 23);
            cboMauSac.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(351, 20);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 20;
            label8.Text = "Màu sắc (*):";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(517, 20);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 18;
            label7.Text = "Size giày (*):";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(858, 86);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 28);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanNhap
            // 
            btnXacNhanNhap.Anchor = AnchorStyles.Top;
            btnXacNhanNhap.ForeColor = Color.Blue;
            btnXacNhanNhap.Location = new Point(726, 87);
            btnXacNhanNhap.Margin = new Padding(3, 2, 3, 2);
            btnXacNhanNhap.Name = "btnXacNhanNhap";
            btnXacNhanNhap.Size = new Size(119, 28);
            btnXacNhanNhap.TabIndex = 12;
            btnXacNhanNhap.Text = "Xác nhận nhập";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            btnXacNhanNhap.Click += btnXacNhanNhap_Click;
            // 
            // numDonGiaNhap
            // 
            numDonGiaNhap.Anchor = AnchorStyles.Top;
            numDonGiaNhap.Location = new Point(858, 44);
            numDonGiaNhap.Margin = new Padding(3, 2, 3, 2);
            numDonGiaNhap.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numDonGiaNhap.Name = "numDonGiaNhap";
            numDonGiaNhap.Size = new Size(131, 23);
            numDonGiaNhap.TabIndex = 11;
            numDonGiaNhap.ThousandsSeparator = true;
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Anchor = AnchorStyles.Top;
            numSoLuongNhap.Location = new Point(691, 44);
            numSoLuongNhap.Margin = new Padding(3, 2, 3, 2);
            numSoLuongNhap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(131, 23);
            numSoLuongNhap.TabIndex = 10;
            numSoLuongNhap.ThousandsSeparator = true;
            // 
            // cboGiay
            // 
            cboGiay.Anchor = AnchorStyles.Top;
            cboGiay.FormattingEnabled = true;
            cboGiay.Location = new Point(19, 44);
            cboGiay.Margin = new Padding(3, 2, 3, 2);
            cboGiay.Name = "cboGiay";
            cboGiay.Size = new Size(288, 23);
            cboGiay.TabIndex = 9;
            cboGiay.SelectionChangeCommitted += cboGiay_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(858, 20);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 16;
            label6.Text = "Đơn giá nhập (*):";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(691, 20);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 15;
            label5.Text = "Số lượng nhập (*):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(19, 20);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 14;
            label4.Text = "Giày (*):";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(btnInPhieuNhap);
            panel1.Controls.Add(btnLuuPhieuNhap);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 410);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 75);
            panel1.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(734, 32);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(77, 15);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền: 0đ";
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Anchor = AnchorStyles.Top;
            btnInPhieuNhap.Location = new Point(396, 29);
            btnInPhieuNhap.Margin = new Padding(3, 2, 3, 2);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(104, 22);
            btnInPhieuNhap.TabIndex = 3;
            btnInPhieuNhap.Text = "In phiếu nhập...";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Anchor = AnchorStyles.Top;
            btnLuuPhieuNhap.ForeColor = Color.Blue;
            btnLuuPhieuNhap.Location = new Point(273, 29);
            btnLuuPhieuNhap.Margin = new Padding(3, 2, 3, 2);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(117, 22);
            btnLuuPhieuNhap.TabIndex = 2;
            btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://maithiencan.github.io/helpqlbg/phieunhap.html";
            // 
            // frmPhieuNhap_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 485);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            helpProvider1.SetHelpKeyword(this, "F1");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1016, 524);
            Name = "frmPhieuNhap_ChiTiet";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            Load += frmPhieuNhap_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSizeGiay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private ComboBox cboMauSac;
        private Label label8;
        private Label label7;
        private Button btnXoa;
        private Button btnXacNhanNhap;
        private NumericUpDown numDonGiaNhap;
        private NumericUpDown numSoLuongNhap;
        private ComboBox cboGiay;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblTongTien;
        private Button btnInPhieuNhap;
        private Button btnLuuPhieuNhap;
        private NumericUpDown numSizeGiay;
        private Panel panel2;
        private DataGridView dataGridView;
        private Label lblLoaiGiay;
        private Label lblThuongHieu;
        private DataGridViewTextBoxColumn SizeGiayID;
        private DataGridViewTextBoxColumn TenGiay;
        private DataGridViewTextBoxColumn TenMau;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        private HelpProvider helpProvider1;
    }
}