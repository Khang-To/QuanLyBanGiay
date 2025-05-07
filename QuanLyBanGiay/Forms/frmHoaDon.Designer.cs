namespace QuanLyBanGiay.Forms
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            btnLamMoi = new ToolStripButton();
            panel1 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnInHoaDon = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(toolStrip);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 50);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(823, 438);
            dataGridView.TabIndex = 6;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            dataGridViewCellStyle1.Format = "N0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle2;
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat, btnLamMoi });
            toolStrip.Location = new Point(3, 19);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(823, 31);
            toolStrip.TabIndex = 5;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(60, 28);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(140, 31);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.find;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(56, 28);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnNhap
            // 
            btnNhap.Image = Properties.Resources.import1;
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(73, 28);
            btnNhap.Text = "Nhập...";
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Image = Properties.Resources.export2;
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(68, 28);
            btnXuat.Text = "Xuất...";
            btnXuat.Click += btnXuat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageTransparentColor = Color.Magenta;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(82, 28);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 58);
            panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(699, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(600, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 34);
            btnSua.TabIndex = 2;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInHoaDon.Location = new Point(227, 12);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(176, 34);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Text = "IN HÓA ĐƠN...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(45, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(176, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "LẬP HÓA ĐƠN MỚI...";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 491);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(845, 530);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private ToolStripButton btnLamMoi;
        private DataGridView dataGridView;
        private Button btnXoa;
        private Button btnSua;
        private Button btnInHoaDon;
        private Button btnThem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
    }
}