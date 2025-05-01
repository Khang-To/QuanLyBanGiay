namespace QuanLyBanGiay.Forms
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLi = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuThuongHieu = new ToolStripMenuItem();
            mnuLoaiGiay = new ToolStripMenuItem();
            mnuMauGiay = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuGiay = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            mnuKho = new ToolStripMenuItem();
            mnuGiaoDich = new ToolStripMenuItem();
            mnuNhapHang = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeHoaDon = new ToolStripMenuItem();
            mnuThongKeNhapHang = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            lOẠIGIÀYToolStripMenuItem = new ToolStripMenuItem();
            tHƯƠNGHIỆUToolStripMenuItem = new ToolStripMenuItem();
            mÀUGIÀYToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            gIÀYToolStripMenuItem = new ToolStripMenuItem();
            kHÁCHHÀNGToolStripMenuItem = new ToolStripMenuItem();
            nHÀCUNGCẤPToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblNgayGio = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            mnuDoiMatKhau = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLi, mnuGiaoDich, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1044, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(79, 20);
            mnuHeThong.Text = "&HỆ THỐNG";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(180, 22);
            mnuDangNhap.Text = "ĐĂNG &NHẬP...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(180, 22);
            mnuDangXuat.Text = "ĐĂNG &XUẤT...";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(180, 22);
            mnuThoat.Text = "&THOÁT";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLi
            // 
            mnuQuanLi.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhMuc, toolStripSeparator5, mnuNhaCungCap, mnuKhachHang, mnuNhanVien, toolStripSeparator6, mnuKho });
            mnuQuanLi.Name = "mnuQuanLi";
            mnuQuanLi.Size = new Size(65, 20);
            mnuQuanLi.Text = "&QUẢN LÍ";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuThuongHieu, mnuLoaiGiay, mnuMauGiay, toolStripSeparator4, mnuGiay });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(175, 22);
            mnuDanhMuc.Text = "&DANH MỤC GIÀY...";
            // 
            // mnuThuongHieu
            // 
            mnuThuongHieu.Name = "mnuThuongHieu";
            mnuThuongHieu.Size = new Size(162, 22);
            mnuThuongHieu.Text = "&THƯƠNG HIỆU...";
            mnuThuongHieu.Click += mnuThuongHieu_Click;
            // 
            // mnuLoaiGiay
            // 
            mnuLoaiGiay.Name = "mnuLoaiGiay";
            mnuLoaiGiay.Size = new Size(162, 22);
            mnuLoaiGiay.Text = "&LOẠI GIÀY...";
            mnuLoaiGiay.Click += mnuLoaiGiay_Click_1;
            // 
            // mnuMauGiay
            // 
            mnuMauGiay.Name = "mnuMauGiay";
            mnuMauGiay.Size = new Size(162, 22);
            mnuMauGiay.Text = "&MÀU GIÀY...";
            mnuMauGiay.Click += mnuMauGiay_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(159, 6);
            // 
            // mnuGiay
            // 
            mnuGiay.Name = "mnuGiay";
            mnuGiay.Size = new Size(162, 22);
            mnuGiay.Text = "&GIÀY...";
            mnuGiay.Click += mnuGiay_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(172, 6);
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(175, 22);
            mnuNhaCungCap.Text = "&NHÀ CUNG CẤP...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(175, 22);
            mnuKhachHang.Text = "&KHÁCH HÀNG...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(175, 22);
            mnuNhanVien.Text = "NHÂN &VIÊN...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(172, 6);
            // 
            // mnuKho
            // 
            mnuKho.Name = "mnuKho";
            mnuKho.Size = new Size(175, 22);
            mnuKho.Text = "KH&O...";
            // 
            // mnuGiaoDich
            // 
            mnuGiaoDich.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapHang, mnuHoaDon });
            mnuGiaoDich.Name = "mnuGiaoDich";
            mnuGiaoDich.Size = new Size(78, 20);
            mnuGiaoDich.Text = "&GIAO DỊCH";
            // 
            // mnuNhapHang
            // 
            mnuNhapHang.Name = "mnuNhapHang";
            mnuNhapHang.Size = new Size(153, 22);
            mnuNhapHang.Text = "&NHẬP HÀNG...";
            mnuNhapHang.Click += mnuNhapHang_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(153, 22);
            mnuHoaDon.Text = "&HÓA ĐƠN...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeHoaDon, mnuThongKeNhapHang, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(140, 20);
            mnuBaoCaoThongKe.Text = "&BÁO CÁO - THỐNG KÊ";
            // 
            // mnuThongKeHoaDon
            // 
            mnuThongKeHoaDon.Name = "mnuThongKeHoaDon";
            mnuThongKeHoaDon.Size = new Size(214, 22);
            mnuThongKeHoaDon.Text = "THỐNG KÊ &HÓA ĐƠN...";
            // 
            // mnuThongKeNhapHang
            // 
            mnuThongKeNhapHang.Name = "mnuThongKeNhapHang";
            mnuThongKeNhapHang.Size = new Size(214, 22);
            mnuThongKeNhapHang.Text = "THỐNG KÊ &NHẬP HÀNG...";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(214, 22);
            mnuThongKeDoanhThu.Text = "THỐNG KÊ &DOANH THU...";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinPhanMem, mnuHuongDanSuDung });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(71, 20);
            mnuTroGiup.Text = "TRỢ &GIÚP";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(253, 22);
            mnuThongTinPhanMem.Text = "&THÔNG TIN PHẦN MỀM...";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(253, 22);
            mnuHuongDanSuDung.Text = "HƯỚNG &DẪN SỬ DỤNG...";
            // 
            // lOẠIGIÀYToolStripMenuItem
            // 
            lOẠIGIÀYToolStripMenuItem.Name = "lOẠIGIÀYToolStripMenuItem";
            lOẠIGIÀYToolStripMenuItem.Size = new Size(180, 22);
            lOẠIGIÀYToolStripMenuItem.Text = "&LOẠI GIÀY...";
            // 
            // tHƯƠNGHIỆUToolStripMenuItem
            // 
            tHƯƠNGHIỆUToolStripMenuItem.Name = "tHƯƠNGHIỆUToolStripMenuItem";
            tHƯƠNGHIỆUToolStripMenuItem.Size = new Size(180, 22);
            tHƯƠNGHIỆUToolStripMenuItem.Text = "&THƯƠNG HIỆU...";
            // 
            // mÀUGIÀYToolStripMenuItem
            // 
            mÀUGIÀYToolStripMenuItem.Name = "mÀUGIÀYToolStripMenuItem";
            mÀUGIÀYToolStripMenuItem.Size = new Size(180, 22);
            mÀUGIÀYToolStripMenuItem.Text = "&MÀU GIÀY...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // gIÀYToolStripMenuItem
            // 
            gIÀYToolStripMenuItem.Name = "gIÀYToolStripMenuItem";
            gIÀYToolStripMenuItem.Size = new Size(180, 22);
            gIÀYToolStripMenuItem.Text = "&GIÀY...";
            // 
            // kHÁCHHÀNGToolStripMenuItem
            // 
            kHÁCHHÀNGToolStripMenuItem.Name = "kHÁCHHÀNGToolStripMenuItem";
            kHÁCHHÀNGToolStripMenuItem.Size = new Size(180, 22);
            kHÁCHHÀNGToolStripMenuItem.Text = "&KHÁCH HÀNG...";
            // 
            // nHÀCUNGCẤPToolStripMenuItem
            // 
            nHÀCUNGCẤPToolStripMenuItem.Name = "nHÀCUNGCẤPToolStripMenuItem";
            nHÀCUNGCẤPToolStripMenuItem.Size = new Size(180, 22);
            nHÀCUNGCẤPToolStripMenuItem.Text = "NHÀ &CUNG CẤP...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(163, 6);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblNgayGio, lblLienKet });
            statusStrip1.Location = new Point(0, 603);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1044, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.Red;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(118, 21);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(712, 21);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblNgayGio
            // 
            lblNgayGio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayGio.ForeColor = Color.Red;
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(88, 21);
            lblNgayGio.Text = "lblNgayGio";
            // 
            // lblLienKet
            // 
            lblLienKet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(111, 21);
            lblLienKet.Text = "@GiayDaBong";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(180, 22);
            mnuDoiMatKhau.Text = "ĐỔI &MẬT KHẨU...";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 629);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1060, 668);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lí bán giày đá bóng";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLi;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem lOẠIGIÀYToolStripMenuItem;
        private ToolStripMenuItem tHƯƠNGHIỆUToolStripMenuItem;
        private ToolStripMenuItem mÀUGIÀYToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem gIÀYToolStripMenuItem;
        private ToolStripMenuItem kHÁCHHÀNGToolStripMenuItem;
        private ToolStripMenuItem nHÀCUNGCẤPToolStripMenuItem;
        private ToolStripMenuItem mnuGiaoDich;
        private ToolStripMenuItem mnuNhapHang;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuThongKeHoaDon;
        private ToolStripMenuItem mnuThongKeNhapHang;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuThuongHieu;
        private ToolStripMenuItem mnuLoaiGiay;
        private ToolStripMenuItem mnuMauGiay;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuGiay;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem mnuKho;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripStatusLabel lblNgayGio;
        private System.Windows.Forms.Timer timer;
        private ToolStripMenuItem mnuDoiMatKhau;
    }
}