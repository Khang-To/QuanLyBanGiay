using QuanLyBanGiay.Data;
using QuanLyBanGiay.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanGiay.Forms
{
    public partial class frmMain : Form
    {
        frmMauSac? mauSac = null;
        frmThuongHieu? thuongHieu = null;
        frmLoaiGiay? loaiGiay = null;
        frmKhachHang? khachHang = null;
        frmNhaCungCap? nhaCungCap = null;
        frmGiay? giay = null;
        frmHoaDon? hoaDon = null;
        frmPhieuNhap? phieuNhap = null;
        frmNhanVien? nhanVien = null;
        frmDangNhap? dangNhap = null;
        frmDoiMatKhau? doiMatKhau = null;
        frmTonKho? tonKho = null;
        frmThongKeGiay? thongKeGiay = null;
        frmThongKeDoanhThu? thongKeDoanhThu = null;
        frmThongKePhieuNhap? thongKePhieuNhap = null;
        string hoVaTenNhanVien = "";

        frmSplashScreen splashScreen = new frmSplashScreen();

        public static class DangNhapSession
        {
            public static int NhanVienID;
            public static string TenDangNhap;
        }

        public frmMain()
        {
            InitializeComponent();
            splashScreen.ShowDialog();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.facebook.com/profile.php?id=61554853380334";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở trình duyệt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
            ChuaPhanQuyen();
            DangNhap();
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text.Trim();
                string matKhau = dangNhap.txtMatKhau.Text;

                if (tenDangNhap == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    using (var context = new QLBGDbContext())
                    {
                        var nhanVien = context.NhanViens.SingleOrDefault(r => r.TenDangNhap == tenDangNhap);

                        if (nhanVien == null)
                        {
                            MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtTenDangNhap.Focus();
                            goto LamLai;
                        }
                        else
                        {
                            if (BC.Verify(matKhau, nhanVien.MatKhau))
                            {
                                hoVaTenNhanVien = nhanVien.HoVaTen;
                                DangNhapSession.NhanVienID = nhanVien.ID;
                                DangNhapSession.TenDangNhap = nhanVien.TenDangNhap;

                                if (nhanVien.QuyenHan == "admin")
                                    QuyenQuanLy();
                                else if (nhanVien.QuyenHan == "user")
                                    QuyenNhanVien();
                                else
                                    ChuaPhanQuyen();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dangNhap.txtMatKhau.Focus();
                                goto LamLai;
                            }
                        }
                    }
                }
            }
        }


        private void ChuaPhanQuyen()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDanhMuc.Enabled = false;
            mnuKho.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuNhapHang.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuThongKeGiay.Enabled = false;
            mnuThongKeNhapHang.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            lblTrangThai.ForeColor = Color.Red;
            lblTrangThai.Font = new Font(lblTrangThai.Font, FontStyle.Bold);
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void QuyenQuanLy()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMuc.Enabled = true;
            mnuKho.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuNhapHang.Enabled = true;
            mnuNhaCungCap.Enabled = true;
            mnuThongKeGiay.Enabled = true;
            mnuThongKeNhapHang.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            lblTrangThai.ForeColor = Color.Blue;
            lblTrangThai.Font = new Font(lblTrangThai.Font, FontStyle.Bold);
            lblTrangThai.Text = "Quản lí: " + hoVaTenNhanVien;
        }

        private void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDanhMuc.Enabled = false;
            mnuKho.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = true;
            mnuNhapHang.Enabled = true;
            mnuNhaCungCap.Enabled = false;
            mnuThongKeGiay.Enabled = false;
            mnuThongKeNhapHang.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            lblTrangThai.ForeColor = Color.Green;
            lblTrangThai.Font = new Font(lblTrangThai.Font, FontStyle.Bold);
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form child in MdiChildren)
                {
                    child.Close();
                }
                ChuaPhanQuyen();
                DangNhap();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuThuongHieu_Click(object sender, EventArgs e)
        {
            if (thuongHieu == null || thuongHieu.IsDisposed)
            {
                thuongHieu = new frmThuongHieu();
                thuongHieu.MdiParent = this;
                thuongHieu.Show();
            }
            else
            {
                thuongHieu.Activate();
            }
        }

        private void mnuMauGiay_Click(object sender, EventArgs e)
        {
            if (mauSac == null || mauSac.IsDisposed)
            {
                mauSac = new frmMauSac();
                mauSac.MdiParent = this;
                mauSac.Show();
            }
            else
            {
                mauSac.Activate();
            }
        }

        private void mnuLoaiGiay_Click_1(object sender, EventArgs e)
        {
            if (loaiGiay == null || loaiGiay.IsDisposed)
            {
                loaiGiay = new frmLoaiGiay();
                loaiGiay.MdiParent = this;
                loaiGiay.Show();
            }
            else
            {
                loaiGiay.Activate();
            }
        }

        private void mnuGiay_Click(object sender, EventArgs e)
        {
            if (giay == null || giay.IsDisposed)
            {
                giay = new frmGiay();
                giay.MdiParent = this;
                giay.Show();
            }
            else
            {
                giay.Activate();
            }
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
            {
                nhaCungCap.Activate();
            }
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
            {
                khachHang.Activate();
            }
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
            {
                nhanVien.Activate();
            }
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
            {
                phieuNhap.Activate();
            }
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (doiMatKhau == null || doiMatKhau.IsDisposed)
            {
                var frm = new frmDoiMatKhau(DangNhapSession.TenDangNhap);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                doiMatKhau.Activate();
            }
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
            {
                hoaDon.Activate();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblNgayGio.Text = "D: " + DateTime.Now.ToString("dddd dd/MM/yyyy") + ", H: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void mnuKho_Click(object sender, EventArgs e)
        {
            if (tonKho == null || tonKho.IsDisposed)
            {
                tonKho = new frmTonKho();
                tonKho.MdiParent = this;
                tonKho.Show();
            }
            else
            {
                tonKho.Activate();
            }
        }

        private void mnuThongKeGiay_Click(object sender, EventArgs e)
        {
            if (thongKeGiay == null || thongKeGiay.IsDisposed)
            {
                thongKeGiay = new frmThongKeGiay();
                thongKeGiay.MdiParent = this;
                thongKeGiay.Show();
            }
            else
            {
                thongKeGiay.Activate();
            }
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
            {
                thongKeDoanhThu.Activate();
            }
        }

        private void mnuThongKeNhapHang_Click(object sender, EventArgs e)
        {
            if (thongKePhieuNhap == null || thongKePhieuNhap.IsDisposed)
            {
                thongKePhieuNhap = new frmThongKePhieuNhap();
                thongKePhieuNhap.MdiParent = this;
                thongKePhieuNhap.Show();
            }
            else
            {
                thongKePhieuNhap.Activate();
            }
        }
    }
}
