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
            mnuDoiMatKhau = new ToolStripMenuItem();
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
            mnuThongKeGiay = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
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
            toolStrip1 = new ToolStrip();
            btnDangNhap = new ToolStripButton();
            btnDangXuat = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            btnKho = new ToolStripButton();
            btnBanGiay = new ToolStripButton();
            btnNhapGiay = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            btnThongKeGiay = new ToolStripButton();
            btnThongKeDoanhThu = new ToolStripButton();
            btnThongKePhieuNhap = new ToolStripButton();
            helpProvider = new HelpProvider();
            pnAdminTools = new Panel();
            lblSLNV = new Label();
            label4 = new Label();
            lblSLGiay = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnNhanVien = new Button();
            btnNhaCungCap = new Button();
            btnGiay = new Button();
            btnMauSac = new Button();
            btnLoaiGiay = new Button();
            btnThuongHieu = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnAdminTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLi, mnuGiaoDich, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1269, 24);
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
            mnuDangNhap.Image = Properties.Resources.login_4661334;
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(167, 22);
            mnuDangNhap.Text = "ĐĂNG &NHẬP...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Image = Properties.Resources._16697253;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(167, 22);
            mnuDangXuat.Text = "ĐĂNG &XUẤT...";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Image = Properties.Resources._6195699;
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(167, 22);
            mnuDoiMatKhau.Text = "ĐỔI &MẬT KHẨU...";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(164, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Image = Properties.Resources.Crystal_Clear_action_exit_svg;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(167, 22);
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
            mnuDanhMuc.Image = Properties.Resources.list_icon_png_265066;
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
            mnuNhaCungCap.Image = Properties.Resources._4495474_200;
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(175, 22);
            mnuNhaCungCap.Text = "&NHÀ CUNG CẤP...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Image = Properties.Resources.user;
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(175, 22);
            mnuKhachHang.Text = "&KHÁCH HÀNG...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Image = Properties.Resources._16864284;
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
            mnuKho.Image = Properties.Resources._9096015;
            mnuKho.Name = "mnuKho";
            mnuKho.Size = new Size(175, 22);
            mnuKho.Text = "KH&O...";
            mnuKho.Click += mnuKho_Click;
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
            mnuNhapHang.Image = Properties.Resources._2264841;
            mnuNhapHang.Name = "mnuNhapHang";
            mnuNhapHang.Size = new Size(153, 22);
            mnuNhapHang.Text = "&NHẬP HÀNG...";
            mnuNhapHang.Click += mnuNhapHang_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Image = Properties.Resources.bills_3;
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(153, 22);
            mnuHoaDon.Text = "&HÓA ĐƠN...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeGiay, toolStripSeparator7, mnuThongKeNhapHang, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(140, 20);
            mnuBaoCaoThongKe.Text = "&BÁO CÁO - THỐNG KÊ";
            // 
            // mnuThongKeGiay
            // 
            mnuThongKeGiay.Name = "mnuThongKeGiay";
            mnuThongKeGiay.Size = new Size(214, 22);
            mnuThongKeGiay.Text = "THỐNG KÊ &GIÀY...";
            mnuThongKeGiay.Click += mnuThongKeGiay_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(211, 6);
            // 
            // mnuThongKeNhapHang
            // 
            mnuThongKeNhapHang.Name = "mnuThongKeNhapHang";
            mnuThongKeNhapHang.Size = new Size(214, 22);
            mnuThongKeNhapHang.Text = "THỐNG KÊ &NHẬP HÀNG...";
            mnuThongKeNhapHang.Click += mnuThongKeNhapHang_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(214, 22);
            mnuThongKeDoanhThu.Text = "THỐNG KÊ &DOANH THU...";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
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
            mnuThongTinPhanMem.Image = Properties.Resources._3357329;
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(253, 22);
            mnuThongTinPhanMem.Text = "&THÔNG TIN PHẦN MỀM...";
            mnuThongTinPhanMem.Click += mnuThongTinPhanMem_Click;
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Image = Properties.Resources.png_transparent_computer_icons_technical_support_help_miscellaneous_blue_text_thumbnail;
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(253, 22);
            mnuHuongDanSuDung.Text = "HƯỚNG &DẪN SỬ DỤNG...";
            mnuHuongDanSuDung.Click += mnuHuongDanSuDung_Click;
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
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblNgayGio, lblLienKet });
            statusStrip1.Location = new Point(0, 822);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1269, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.Red;
            lblTrangThai.Image = Properties.Resources.status_online_icon_152750;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(138, 21);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(897, 21);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblNgayGio
            // 
            lblNgayGio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayGio.ForeColor = Color.Red;
            lblNgayGio.Image = Properties.Resources.calendar_clock_icon_34472;
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(108, 21);
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
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDangNhap, btnDangXuat, toolStripSeparator8, btnKho, btnBanGiay, btnNhapGiay, toolStripSeparator9, btnThongKeGiay, btnThongKeDoanhThu, btnThongKePhieuNhap });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1269, 54);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Image = Properties.Resources.dang_nhap1;
            btnDangNhap.ImageScaling = ToolStripItemImageScaling.None;
            btnDangNhap.ImageTransparentColor = Color.Magenta;
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(80, 51);
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Image = Properties.Resources.dang_xuat;
            btnDangXuat.ImageScaling = ToolStripItemImageScaling.None;
            btnDangXuat.ImageTransparentColor = Color.Magenta;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(77, 51);
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 54);
            // 
            // btnKho
            // 
            btnKho.Image = Properties.Resources.warehouse_storage_unit_storehouse_icon_192428;
            btnKho.ImageScaling = ToolStripItemImageScaling.None;
            btnKho.ImageTransparentColor = Color.Magenta;
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(36, 51);
            btnKho.Text = "KHO";
            btnKho.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKho.Click += btnKho_Click;
            // 
            // btnBanGiay
            // 
            btnBanGiay.Image = Properties.Resources.hoa_don;
            btnBanGiay.ImageScaling = ToolStripItemImageScaling.None;
            btnBanGiay.ImageTransparentColor = Color.Magenta;
            btnBanGiay.Name = "btnBanGiay";
            btnBanGiay.Size = new Size(63, 51);
            btnBanGiay.Text = "BÁN GIÀY";
            btnBanGiay.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBanGiay.Click += btnBanGiay_Click;
            // 
            // btnNhapGiay
            // 
            btnNhapGiay.Image = Properties.Resources.san_pham;
            btnNhapGiay.ImageScaling = ToolStripItemImageScaling.None;
            btnNhapGiay.ImageTransparentColor = Color.Magenta;
            btnNhapGiay.Name = "btnNhapGiay";
            btnNhapGiay.Size = new Size(72, 51);
            btnNhapGiay.Text = "NHẬP GIÀY";
            btnNhapGiay.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNhapGiay.Click += btnNhapGiay_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 54);
            // 
            // btnThongKeGiay
            // 
            btnThongKeGiay.Image = Properties.Resources.thong_ke_san_pham;
            btnThongKeGiay.ImageScaling = ToolStripItemImageScaling.None;
            btnThongKeGiay.ImageTransparentColor = Color.Magenta;
            btnThongKeGiay.Name = "btnThongKeGiay";
            btnThongKeGiay.Size = new Size(97, 51);
            btnThongKeGiay.Text = "THỐNG KÊ GIÀY";
            btnThongKeGiay.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThongKeGiay.Click += btnThongKeGiay_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.Image = Properties.Resources.thong_ke_doanh_thu;
            btnThongKeDoanhThu.ImageScaling = ToolStripItemImageScaling.None;
            btnThongKeDoanhThu.ImageTransparentColor = Color.Magenta;
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(142, 51);
            btnThongKeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            btnThongKeDoanhThu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // btnThongKePhieuNhap
            // 
            btnThongKePhieuNhap.Image = Properties.Resources.Icon_Business_Set_00008_A_icon_icons_com_59853;
            btnThongKePhieuNhap.ImageScaling = ToolStripItemImageScaling.None;
            btnThongKePhieuNhap.ImageTransparentColor = Color.Magenta;
            btnThongKePhieuNhap.Name = "btnThongKePhieuNhap";
            btnThongKePhieuNhap.Size = new Size(133, 51);
            btnThongKePhieuNhap.Text = "THỐNG KÊ NHẬP KHO";
            btnThongKePhieuNhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThongKePhieuNhap.Click += btnThongKePhieuNhap_Click;
            // 
            // helpProvider
            // 
            helpProvider.HelpNamespace = "https://maithiencan.github.io/helpqlbg/index.html";
            // 
            // pnAdminTools
            // 
            pnAdminTools.Controls.Add(lblSLNV);
            pnAdminTools.Controls.Add(label4);
            pnAdminTools.Controls.Add(lblSLGiay);
            pnAdminTools.Controls.Add(label2);
            pnAdminTools.Controls.Add(pictureBox1);
            pnAdminTools.Controls.Add(btnNhanVien);
            pnAdminTools.Controls.Add(btnNhaCungCap);
            pnAdminTools.Controls.Add(btnGiay);
            pnAdminTools.Controls.Add(btnMauSac);
            pnAdminTools.Controls.Add(btnLoaiGiay);
            pnAdminTools.Controls.Add(btnThuongHieu);
            pnAdminTools.Controls.Add(label1);
            pnAdminTools.Dock = DockStyle.Right;
            pnAdminTools.Location = new Point(1137, 78);
            pnAdminTools.Name = "pnAdminTools";
            pnAdminTools.Size = new Size(132, 744);
            pnAdminTools.TabIndex = 6;
            // 
            // lblSLNV
            // 
            lblSLNV.Anchor = AnchorStyles.Bottom;
            lblSLNV.AutoSize = true;
            lblSLNV.Location = new Point(43, 546);
            lblSLNV.Name = "lblSLNV";
            lblSLNV.Size = new Size(47, 15);
            lblSLNV.TabIndex = 11;
            lblSLNV.Text = "0 người";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(10, 520);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 10;
            label4.Text = "Số lượng nhân viên:";
            // 
            // lblSLGiay
            // 
            lblSLGiay.Anchor = AnchorStyles.Bottom;
            lblSLGiay.AutoSize = true;
            lblSLGiay.Location = new Point(50, 487);
            lblSLGiay.Name = "lblSLGiay";
            lblSLGiay.Size = new Size(33, 15);
            lblSLGiay.TabIndex = 9;
            lblSLGiay.Text = "0 đôi";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(4, 461);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Số lượng giày hiện có:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 619);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhanVien.Location = new Point(12, 357);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(108, 59);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "NHÂN  VIÊN";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhaCungCap.Location = new Point(12, 292);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(108, 59);
            btnNhaCungCap.TabIndex = 5;
            btnNhaCungCap.Text = "NHÀ CUNG CẤP";
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnGiay
            // 
            btnGiay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGiay.Location = new Point(12, 227);
            btnGiay.Name = "btnGiay";
            btnGiay.Size = new Size(108, 59);
            btnGiay.TabIndex = 4;
            btnGiay.Text = "GIÀY";
            btnGiay.UseVisualStyleBackColor = true;
            btnGiay.Click += btnGiay_Click;
            // 
            // btnMauSac
            // 
            btnMauSac.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMauSac.Location = new Point(12, 162);
            btnMauSac.Name = "btnMauSac";
            btnMauSac.Size = new Size(108, 59);
            btnMauSac.TabIndex = 3;
            btnMauSac.Text = "MÀU SẮC";
            btnMauSac.UseVisualStyleBackColor = true;
            btnMauSac.Click += btnMauSac_Click;
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoaiGiay.Location = new Point(12, 97);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(108, 59);
            btnLoaiGiay.TabIndex = 2;
            btnLoaiGiay.Text = "LOẠI GIÀY";
            btnLoaiGiay.UseVisualStyleBackColor = true;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // btnThuongHieu
            // 
            btnThuongHieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThuongHieu.Location = new Point(12, 32);
            btnThuongHieu.Name = "btnThuongHieu";
            btnThuongHieu.Size = new Size(108, 59);
            btnThuongHieu.TabIndex = 1;
            btnThuongHieu.Text = "THƯƠNG HIỆU";
            btnThuongHieu.UseVisualStyleBackColor = true;
            btnThuongHieu.Click += btnThuongHieu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 0;
            label1.Text = "CÔNG CỤ QUẢN LÍ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 848);
            Controls.Add(pnAdminTools);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            helpProvider.SetHelpKeyword(this, "F1");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1060, 666);
            Name = "frmMain";
            helpProvider.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lí bán giày đá bóng";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnAdminTools.ResumeLayout(false);
            pnAdminTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripMenuItem mnuThongKeGiay;
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
        private ToolStripSeparator toolStripSeparator7;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDangNhap;
        private ToolStripButton btnDangXuat;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton btnBanGiay;
        private ToolStripButton btnNhapGiay;
        private HelpProvider helpProvider;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton btnThongKeGiay;
        private ToolStripButton btnThongKeDoanhThu;
        private ToolStripButton btnThongKePhieuNhap;
        private Panel pnAdminTools;
        private Button btnLoaiGiay;
        private Button btnThuongHieu;
        private Label label1;
        private Button btnGiay;
        private Button btnMauSac;
        private Button btnNhanVien;
        private Button btnNhaCungCap;
        private ToolStripButton btnKho;
        private PictureBox pictureBox1;
        private Label lblSLNV;
        private Label label4;
        private Label lblSLGiay;
        private Label label2;
    }
}