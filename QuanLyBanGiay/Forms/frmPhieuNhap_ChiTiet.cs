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
    public partial class frmPhieuNhap_ChiTiet : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id;
        BindingList<DanhSachPhieuNhap_ChiTiet> phieuNhapChiTiet = new BindingList<DanhSachPhieuNhap_ChiTiet>();
        public frmPhieuNhap_ChiTiet(int maPhieuNhap = 0)
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            id = maPhieuNhap;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanViens.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayNhaCungCapVaoComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCaps.ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
        }

        public void layGiayVaoComboBox()
        {
            cboGiay.DataSource = context.Giays.Include(g => g.ThuongHieu).Include(g => g.LoaiGiay).ToList();
            cboGiay.ValueMember = "ID";
            cboGiay.DisplayMember = "TenGiay";
        }

        public void layMauVaoComboBox()
        {
            cboMauSac.DataSource = context.MauSacs.ToList();
            cboMauSac.ValueMember = "ID";
            cboMauSac.DisplayMember = "TenMau";
        }

        public void BatTatChucNang()
        {
            // Bật tắt chức năng khi Thêm phiếu nhập
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                // Xóa trắng các trường
                cboNhaCungCap.Text = "";
                cboNhanVien.Text = "";
                cboGiay.Text = "";
                cboMauSac.Text = "";
                numSoLuongNhap.Value = 1;
                numDonGiaNhap.Value = 0;
                numSizeGiay.Value = 27;
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnLuuPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void tinhTongTien()
        {
            double tongTien = 0;
            foreach (DanhSachPhieuNhap_ChiTiet ctiet in phieuNhapChiTiet)
            {
                tongTien = tongTien + ctiet.ThanhTien;
            }
            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + "đ";
        }

        private void frmPhieuNhap_ChiTiet_Load(object sender, EventArgs e)
        {
            layGiayVaoComboBox();
            layMauVaoComboBox();
            LayNhaCungCapVaoComboBox();
            LayNhanVienVaoComboBox();

            if (id != 0) // Đã tồn tại chi tiết
            {
                var pn = context.PhieuNhaps.Find(id)!;
                cboNhanVien.SelectedValue = pn.NhanVienID;
                cboNhaCungCap.SelectedValue = pn.NhaCungCapID;
                txtGhiChuPhieuNhap.Text = pn.GhiChu;

                var ct = (from r in context.PhieuNhapChiTiets
                          join sg in context.SizeGiays on r.SizeGiayID equals sg.ID
                          join g in context.Giays on sg.GiayID equals g.ID
                          join ms in context.MauSacs on sg.MauSacID equals ms.ID
                          where r.PhieuNhapID == id
                          select new DanhSachPhieuNhap_ChiTiet
                          {
                              ID = r.ID,
                              PhieuNhapID = r.PhieuNhapID,
                              SizeGiayID = r.SizeGiayID,
                              TenGiay = g.TenGiay,
                              TenMau = ms.TenMau,
                              Size = sg.Size,
                              SoLuongNhap = r.SoLuongNhap,
                              DonGiaNhap = r.DonGiaNhap,
                              ThanhTien = r.SoLuongNhap * r.DonGiaNhap
                          }).ToList();

                phieuNhapChiTiet = new BindingList<DanhSachPhieuNhap_ChiTiet>(ct);
            }
            dataGridView.DataSource = phieuNhapChiTiet;
            tinhTongTien();
            BatTatChucNang();
        }

        private void btnXacNhanNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboGiay.Text))
                MessageBox.Show("Vui lòng chọn giày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboMauSac.Text))
                MessageBox.Show("Vui lòng chọn màu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongNhap.Value <= 0)
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaNhap.Value <= 0)
                MessageBox.Show("Đơn giá nhập giày phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int maGiay = Convert.ToInt32(cboGiay.SelectedValue);
                int maMau = Convert.ToInt32(cboMauSac.SelectedValue);
                int size = Convert.ToInt32(numSizeGiay.Value);
                var sizeGiay = context.SizeGiays.FirstOrDefault(s =>
                     s.GiayID == maGiay &&
                     s.MauSacID == maMau &&
                     s.Size == size
                );

                // Tìm xem dòng nào trong danh sách đã có tổ hợp Giay + Mau + Size chưa
                var chiTiet = phieuNhapChiTiet.FirstOrDefault(x =>
                    x.TenGiay == cboGiay.Text &&
                    x.TenMau == cboMauSac.Text &&
                    x.Size == size
                );
                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin
                if (chiTiet != null)
                {
                    chiTiet.SoLuongNhap = Convert.ToInt16(numSoLuongNhap.Value);
                    chiTiet.DonGiaNhap = Convert.ToInt32(numDonGiaNhap.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numDonGiaNhap.Value * numSoLuongNhap.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachPhieuNhap_ChiTiet ct = new DanhSachPhieuNhap_ChiTiet
                    {
                        ID = 0,
                        PhieuNhapID = id,
                        SizeGiayID = 0, // Gán tạm, khi lưu phiếu mới xử lý
                        TenGiay = cboGiay.Text,
                        TenMau = cboMauSac.Text,
                        Size = size,
                        SoLuongNhap = Convert.ToInt32(numSoLuongNhap.Value),
                        DonGiaNhap = Convert.ToInt32(numDonGiaNhap.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongNhap.Value * numDonGiaNhap.Value)
                    };
                    phieuNhapChiTiet.Add(ct);
                }
                tinhTongTien();
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maSizeGiay = Convert.ToInt32(dataGridView.CurrentRow.Cells["SizeGiayID"].Value.ToString());
                var chiTiet = phieuNhapChiTiet.FirstOrDefault(x => x.SizeGiayID == maSizeGiay)!;
                if (chiTiet != null)
                {
                    phieuNhapChiTiet.Remove(chiTiet);
                }
                BatTatChucNang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tinhTongTien();
        }

        private void cboGiay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var giay = cboGiay.SelectedItem as Giay;
            if (giay != null)
            {
                lblThuongHieu.Text = "Thương hiệu: " + giay.ThuongHieu.TenThuongHieu;
                lblLoaiGiay.Text = "Loại giày: " + giay.LoaiGiay.TenLoai;
            }
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Sửa phiếu nhập cũ
                {
                    var pn = context.PhieuNhaps.Include(p => p.PhieuNhapChiTiets).FirstOrDefault(p => p.ID == id);
                    if (pn != null)
                    {
                        // Cập nhật thông tin phiếu nhập
                        pn.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        pn.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                        pn.GhiChu = txtGhiChuPhieuNhap.Text;
                        context.PhieuNhaps.Update(pn);

                        // Trừ lại số lượng tồn trước khi xóa chi tiết cũ
                        foreach (var oldDetail in pn.PhieuNhapChiTiets.ToList())
                        {
                            var oldSizeGiay = context.SizeGiays.FirstOrDefault(s => s.ID == oldDetail.SizeGiayID);
                            if (oldSizeGiay != null)
                            {
                                oldSizeGiay.SoLuongTon -= oldDetail.SoLuongNhap;
                                context.SizeGiays.Update(oldSizeGiay);
                            }
                        }

                        // Xóa chi tiết cũ
                        var old = context.PhieuNhapChiTiets.Where(r => r.PhieuNhapID == id).ToList();
                        context.PhieuNhapChiTiets.RemoveRange(old);

                        // Xử lý lại từng chi tiết mới
                        foreach (var item in phieuNhapChiTiet)
                        {
                            // Tìm SizeGiay phù hợp (GiayID + MauSacID + Size)
                            var sizeGiay = context.SizeGiays.FirstOrDefault(s =>
                                s.GiayID == context.Giays.FirstOrDefault(g => g.TenGiay == item.TenGiay)!.ID &&
                                s.MauSac.TenMau == item.TenMau &&
                                s.Size == item.Size);

                            if (sizeGiay != null)
                            {
                                // Tăng số lượng tồn
                                sizeGiay.SoLuongTon += item.SoLuongNhap;
                                context.SizeGiays.Update(sizeGiay);
                            }
                            else
                            {
                                // Tạo mới SizeGiay
                                sizeGiay = new SizeGiay
                                {
                                    GiayID = context.Giays.First(g => g.TenGiay == item.TenGiay).ID,
                                    MauSacID = context.MauSacs.First(m => m.TenMau == item.TenMau).ID,
                                    Size = item.Size,
                                    SoLuongTon = item.SoLuongNhap
                                };
                                context.SizeGiays.Add(sizeGiay);
                                context.SaveChanges(); // Để lấy ID mới
                            }

                            // Thêm chi tiết phiếu nhập
                            var chiTiet = new PhieuNhap_ChiTiet
                            {
                                PhieuNhapID = pn.ID,
                                SizeGiayID = sizeGiay.ID,
                                SoLuongNhap = item.SoLuongNhap,
                                DonGiaNhap = item.DonGiaNhap
                            };
                            context.PhieuNhapChiTiets.Add(chiTiet);
                        }

                        context.SaveChanges();
                    }
                }
                else // Thêm mới phiếu nhập
                {
                    var pn = new PhieuNhap
                    {
                        NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue),
                        NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue),
                        NgayNhap = DateTime.Now,
                        GhiChu = txtGhiChuPhieuNhap.Text
                    };
                    context.PhieuNhaps.Add(pn);
                    context.SaveChanges();

                    foreach (var item in phieuNhapChiTiet)
                    {
                        var sizeGiay = context.SizeGiays.FirstOrDefault(s =>
                            s.GiayID == context.Giays.FirstOrDefault(g => g.TenGiay == item.TenGiay)!.ID &&
                            s.MauSac.TenMau == item.TenMau &&
                            s.Size == item.Size);

                        if (sizeGiay != null)
                        {
                            sizeGiay.SoLuongTon += item.SoLuongNhap;
                            context.SizeGiays.Update(sizeGiay);
                        }
                        else
                        {
                            sizeGiay = new SizeGiay
                            {
                                GiayID = context.Giays.First(g => g.TenGiay == item.TenGiay).ID,
                                MauSacID = context.MauSacs.First(m => m.TenMau == item.TenMau).ID,
                                Size = item.Size,
                                SoLuongTon = item.SoLuongNhap
                            };
                            context.SizeGiays.Add(sizeGiay);
                            context.SaveChanges();
                        }

                        var chiTiet = new PhieuNhap_ChiTiet
                        {
                            PhieuNhapID = pn.ID,
                            SizeGiayID = sizeGiay.ID,
                            SoLuongNhap = item.SoLuongNhap,
                            DonGiaNhap = item.DonGiaNhap
                        };
                        context.PhieuNhapChiTiets.Add(chiTiet);
                    }

                    context.SaveChanges();
                }
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var row = dataGridView.CurrentRow.DataBoundItem as DanhSachPhieuNhap_ChiTiet;
            if (row != null)
            {
                numDonGiaNhap.Value = row.DonGiaNhap;
                numSoLuongNhap.Value = row.SoLuongNhap;
                numSizeGiay.Value = row.Size;
                cboGiay.Text = row.TenGiay;
                cboMauSac.Text = row.TenMau;
                cboGiay_SelectionChangeCommitted(sender, e);
            }
        }
    }
}
