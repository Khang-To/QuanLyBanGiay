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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLi = new ToolStripMenuItem();
            mnuGiaoDich = new ToolStripMenuItem();
            mnuNhapHang = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeHoaDon = new ToolStripMenuItem();
            mnuThongKeNhapHang = new ToolStripMenuItem();
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
            mnuNhanVien = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuKho = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
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
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(180, 22);
            mnuDoiMatKhau.Text = "ĐỔI &MẬT KHẨU...";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
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
            mnuQuanLi.Name = "mnuQuanLi";
            mnuQuanLi.Size = new Size(65, 20);
            mnuQuanLi.Text = "&QUẢN LÍ";
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
            mnuNhapHang.Size = new Size(180, 22);
            mnuNhapHang.Text = "&NHẬP HÀNG...";
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(180, 22);
            mnuHoaDon.Text = "&HÓA ĐƠN...";
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeHoaDon, mnuThongKeNhapHang });
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
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(166, 22);
            mnuNhanVien.Text = "&NHÂN VIÊN...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(163, 6);
            // 
            // mnuKho
            // 
            mnuKho.Name = "mnuKho";
            mnuKho.Size = new Size(166, 22);
            mnuKho.Text = "&KHO...";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1044, 25);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.Red;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(118, 20);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(828, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(83, 20);
            lblLienKet.Text = "@GiayDaBong";
            lblLienKet.Click += lblLienKet_Click;
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
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLi;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuThietLap;
        private ToolStripMenuItem lOẠIGIÀYToolStripMenuItem;
        private ToolStripMenuItem tHƯƠNGHIỆUToolStripMenuItem;
        private ToolStripMenuItem mÀUGIÀYToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem gIÀYToolStripMenuItem;
        private ToolStripMenuItem đỐITÁCToolStripMenuItem;
        private ToolStripMenuItem kHÁCHHÀNGToolStripMenuItem;
        private ToolStripMenuItem nHÀCUNGCẤPToolStripMenuItem;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuGiaoDich;
        private ToolStripMenuItem mnuNhapHang;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuKho;
        private ToolStripMenuItem mnuThongKeHoaDon;
        private ToolStripMenuItem mnuThongKeNhapHang;
    }
}