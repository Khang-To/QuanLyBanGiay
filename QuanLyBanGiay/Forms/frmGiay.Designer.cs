namespace QuanLyBanGiay.Forms
{
    partial class frmGiay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiay));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTenGiay = new TextBox();
            label2 = new Label();
            cboThuongHieu = new ComboBox();
            cboLoaiGiay = new ComboBox();
            label3 = new Label();
            picHinhAnh = new PictureBox();
            label4 = new Label();
            numGiaBan = new NumericUpDown();
            label5 = new Label();
            txtMoTa = new TextBox();
            label6 = new Label();
            dataGridView = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            btnLamMoi = new ToolStripButton();
            ID = new DataGridViewTextBoxColumn();
            TenGiay = new DataGridViewTextBoxColumn();
            TenThuongHieu = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numGiaBan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboLoaiGiay);
            groupBox1.Controls.Add(cboThuongHieu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenGiay);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mẫu giày:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(684, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách mẫu giày:";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuyBo.ForeColor = SystemColors.Control;
            btnHuyBo.Location = new Point(451, 147);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 32);
            btnHuyBo.TabIndex = 15;
            btnHuyBo.Text = "HỦY BỎ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.BackColor = Color.Green;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = SystemColors.Control;
            btnLuu.Location = new Point(370, 147);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 32);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(226, 147);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 32);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(145, 147);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 32);
            btnSua.TabIndex = 12;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Green;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(64, 147);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 32);
            btnThem.TabIndex = 11;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Tên giày:";
            // 
            // txtTenGiay
            // 
            txtTenGiay.Anchor = AnchorStyles.Top;
            txtTenGiay.Location = new Point(98, 27);
            txtTenGiay.Name = "txtTenGiay";
            txtTenGiay.Size = new Size(203, 23);
            txtTenGiay.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(14, 68);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 18;
            label2.Text = "Thương hiệu:";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.Anchor = AnchorStyles.Top;
            cboThuongHieu.FormattingEnabled = true;
            cboThuongHieu.Location = new Point(98, 65);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(203, 23);
            cboThuongHieu.TabIndex = 19;
            // 
            // cboLoaiGiay
            // 
            cboLoaiGiay.Anchor = AnchorStyles.Top;
            cboLoaiGiay.FormattingEnabled = true;
            cboLoaiGiay.Location = new Point(98, 106);
            cboLoaiGiay.Name = "cboLoaiGiay";
            cboLoaiGiay.Size = new Size(203, 23);
            cboLoaiGiay.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(35, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 21;
            label3.Text = "Loại giày:";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top;
            picHinhAnh.Location = new Point(557, 30);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(115, 149);
            picHinhAnh.TabIndex = 22;
            picHinhAnh.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(307, 29);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 23;
            label4.Text = "Giá bán:";
            // 
            // numGiaBan
            // 
            numGiaBan.Anchor = AnchorStyles.Top;
            numGiaBan.Location = new Point(363, 27);
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(103, 23);
            numGiaBan.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(316, 85);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 25;
            label5.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.Top;
            txtMoTa.Location = new Point(363, 65);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(188, 64);
            txtMoTa.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(587, 12);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 27;
            label6.Text = "Hình ảnh";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenGiay, TenThuongHieu, TenLoai, GiaBan, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 50);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(678, 299);
            dataGridView.TabIndex = 5;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat, btnLamMoi });
            toolStrip.Location = new Point(3, 19);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(678, 31);
            toolStrip.TabIndex = 4;
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
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.find;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(56, 28);
            btnTimKiem.Text = "Tìm";
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
            // 
            // btnXuat
            // 
            btnXuat.Image = Properties.Resources.export2;
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(68, 28);
            btnXuat.Text = "Xuất...";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageTransparentColor = Color.Magenta;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(82, 28);
            btnLamMoi.Text = "Làm mới";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenGiay
            // 
            TenGiay.DataPropertyName = "TenGiay";
            TenGiay.HeaderText = "Tên giày";
            TenGiay.Name = "TenGiay";
            TenGiay.ReadOnly = true;
            // 
            // TenThuongHieu
            // 
            TenThuongHieu.DataPropertyName = "TenThuongHieu";
            TenThuongHieu.HeaderText = "Thương hiệu";
            TenThuongHieu.Name = "TenThuongHieu";
            TenThuongHieu.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại giày";
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá bán";
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmGiay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 541);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(700, 580);
            Name = "frmGiay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mẫu giày";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboThuongHieu;
        private Label label2;
        private TextBox txtTenGiay;
        private Label label1;
        private PictureBox picHinhAnh;
        private Label label3;
        private ComboBox cboLoaiGiay;
        private NumericUpDown numGiaBan;
        private Label label4;
        private Label label6;
        private TextBox txtMoTa;
        private Label label5;
        private DataGridView dataGridView;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private ToolStripButton btnLamMoi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenGiay;
        private DataGridViewTextBoxColumn TenThuongHieu;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewImageColumn HinhAnh;
    }
}