namespace QuanLyBanGiay.Forms
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenThuongHieu = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenGiay = new DataGridViewTextBoxColumn();
            TenMau = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            toolStrip2 = new ToolStrip();
            toolStripLabel5 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            toolStripSeparator4 = new ToolStripSeparator();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnXuat = new ToolStripButton();
            btnLamMoi = new ToolStripButton();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            cboLoaiGiay = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            cboThuongHieu = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            cboMauSac = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel4 = new ToolStripLabel();
            cboSizeGiay = new ToolStripComboBox();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(toolStrip2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(852, 389);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách giày trong kho";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenThuongHieu, TenLoai, TenGiay, TenMau, Size, SoLuongTon });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 82);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(846, 305);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenThuongHieu
            // 
            TenThuongHieu.DataPropertyName = "TenThuongHieu";
            TenThuongHieu.HeaderText = "Thương hiệu";
            TenThuongHieu.MinimumWidth = 6;
            TenThuongHieu.Name = "TenThuongHieu";
            TenThuongHieu.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại giày";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
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
            TenMau.HeaderText = "Màu";
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
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel5, txtTuKhoa, toolStripSeparator4, btnTimKiem, toolStripSeparator5, btnXuat, btnLamMoi });
            toolStrip2.Location = new Point(3, 51);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Padding = new Padding(0, 2, 1, 2);
            toolStrip2.Size = new Size(846, 31);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(54, 24);
            toolStripLabel5.Text = "Tên giày:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.AutoSize = false;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(263, 23);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.find;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(52, 24);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // btnXuat
            // 
            btnXuat.Image = Properties.Resources.export2;
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(64, 24);
            btnXuat.Text = "Xuất...";
            btnXuat.Click += btnXuat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageTransparentColor = Color.Magenta;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(78, 24);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 43);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 8);
            panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, cboLoaiGiay, toolStripSeparator1, toolStripLabel2, cboThuongHieu, toolStripSeparator2, toolStripLabel3, cboMauSac, toolStripSeparator3, toolStripLabel4, cboSizeGiay });
            toolStrip1.Location = new Point(3, 18);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(846, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(57, 22);
            toolStripLabel1.Text = "Loại giày:";
            // 
            // cboLoaiGiay
            // 
            cboLoaiGiay.AutoSize = false;
            cboLoaiGiay.Name = "cboLoaiGiay";
            cboLoaiGiay.Size = new Size(176, 23);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(78, 22);
            toolStripLabel2.Text = "Thương hiệu:";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.AutoSize = false;
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(176, 23);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(34, 22);
            toolStripLabel3.Text = "Màu:";
            // 
            // cboMauSac
            // 
            cboMauSac.Name = "cboMauSac";
            cboMauSac.Size = new Size(106, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(30, 22);
            toolStripLabel4.Text = "Size:";
            // 
            // cboSizeGiay
            // 
            cboSizeGiay.Name = "cboSizeGiay";
            cboSizeGiay.Size = new Size(106, 25);
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://maithiencan.github.io/helpqlbg/kho.html";
            // 
            // frmTonKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 389);
            Controls.Add(groupBox1);
            helpProvider1.SetHelpKeyword(this, "F1");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(868, 428);
            Name = "frmTonKho";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kho";
            Load += frmTonKho_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenThuongHieu;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenGiay;
        private DataGridViewTextBoxColumn TenMau;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn SoLuongTon;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel5;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnXuat;
        private ToolStripButton btnLamMoi;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cboLoaiGiay;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox cboThuongHieu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripComboBox cboMauSac;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripComboBox cboSizeGiay;
        private HelpProvider helpProvider1;
    }
}