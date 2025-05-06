using Microsoft.EntityFrameworkCore;
using QuanLyBanGiay.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        frmKhachHang? frmKhachHang = null!;
        QLBGDbContext context = new QLBGDbContext();
        int id = 0;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            id = maHoaDon;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanViens.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHangs.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LayGiayVaoComboBox()
        {
            var danhSach = context.SizeGiays.Include(r => r.Giay).Include(r => r.MauSac).Select(r => new { ID = r.ID, TenSanPham = r.Giay.TenGiay + " - " + r.MauSac.TenMau + " - Size " + r.Size }).ToList();
            cboSanPham.DataSource = danhSach;
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numDonGiaBan.Value = 0;
                numSoLuongBan.Value = 1;
            }
            btnLuu.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text)) MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboKhachHang.Text)) MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0)
                {
                    HoaDon hd = context.HoaDons.Find(id)!; if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue?.ToString());
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue?.ToString());
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text; context.HoaDons.Update(hd);
                        var old = context.HoaDonChiTiets.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDonChiTiets.RemoveRange(old);

                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                            ct.HoaDonID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuongBan = item.SoLuongBan;
                            ct.DonGiaBan = item.DonGiaBan;
                            context.HoaDonChiTiets.Add(ct);

                            var sizeGiay = context.SizeGiays.Find(item.SanPhamID);
                            if (sizeGiay != null)
                            {
                                if (sizeGiay.SoLuongTon >= item.SoLuongBan)
                                    sizeGiay.SoLuongTon -= item.SoLuongBan;
                                else
                                {
                                    MessageBox.Show($"Không đủ tồn kho cho sản phẩm: {item.TenSanPham}.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }

                        context.SaveChanges();
                    }
                }
                else
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue?.ToString());
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue?.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDons.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                        ct.HoaDonID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDonChiTiets.Add(ct);

                        var sizeGiay = context.SizeGiays.Find(item.SanPhamID);
                        if (sizeGiay != null)
                        {
                            if (sizeGiay.SoLuongTon >= item.SoLuongBan)
                                sizeGiay.SoLuongTon -= item.SoLuongBan;
                            else
                            {
                                MessageBox.Show($"Không đủ tồn kho cho sản phẩm: {item.TenSanPham}.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu thành công và cập nhật tồn kho!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham)!;
                if (chiTiet != null)
                {
                    hoaDonChiTiet.Remove(chiTiet);
                }
                BatTatChucNang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
            LayKhachHangVaoComboBox();
            LayNhanVienVaoComboBox();
            if (id != 0)
            {
                var ct = context.HoaDonChiTiets.Where(r => r.HoaDonID == id)
                    .Include(r => r.SizeGiay).ThenInclude(sg => sg.Giay).
                    Include(r => r.SizeGiay).ThenInclude(sg => sg.MauSac).
                    Select(r => new DanhSachHoaDon_ChiTiet
                    {
                        ID = r.ID,
                        HoaDonID = r.HoaDonID,
                        SanPhamID = r.SanPhamID,
                        TenSanPham = r.SizeGiay.Giay.TenGiay + " - " + r.SizeGiay.MauSac.TenMau + " - Size " + r.SizeGiay.Size,
                        SoLuongBan = r.SoLuongBan,
                        DonGiaBan = r.DonGiaBan,
                        ThanhTien = r.SoLuongBan * r.DonGiaBan
                    }).ToList();

                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue?.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);
                    dataGridView.Refresh();
                }
                else
                {
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue?.ToString());
                var sanPham = context.Giays.Find(maSanPham)!;
                numDonGiaBan.Value = sanPham.GiaBan;
            }
        }

        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            if (frmKhachHang == null || frmKhachHang.IsDisposed)
            {
                var frmKhachHang = new frmKhachHang();
                frmKhachHang.MdiParent = this.MdiParent;
                frmKhachHang.Show();

            }
            else
            {
                frmKhachHang.Activate();
            }
        }
    }
}
