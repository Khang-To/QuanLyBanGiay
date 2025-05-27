using Microsoft.EntityFrameworkCore;
using QuanLyBanGiay.Data;
using QuanLyBanGiay.Reports;
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
        QLBGDbContext context = new QLBGDbContext();
        int id = 0;
        private int? editingRowIndex = null;

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

        public void LayLoaiGiayVaoComboBox()
        {
            var ds = context.LoaiGiays.ToList();
            ds.Insert(0, new LoaiGiay { ID = 0, TenLoai = "Tất cả" });
            cboLoaiGiay.DataSource = ds;
            cboLoaiGiay.ValueMember = "ID";
            cboLoaiGiay.DisplayMember = "TenLoai";
        }

        public void LayMauSacVaoComboBox()
        {
            var ds = context.MauSacs.ToList();
            ds.Insert(0, new MauSac { ID = 0, TenMau = "Tất cả" });
            cboMauSac.DataSource = ds;
            cboMauSac.ValueMember = "ID";
            cboMauSac.DisplayMember = "TenMau";
        }

        public void LaySizeVaoComboBox()
        {
            var ds = context.SizeGiays.Select(sg => sg.Size).Distinct().OrderBy(s => s).ToList();
            ds.Insert(0, 0);
            cboSize.DataSource = ds;
        }

        private void CapNhatSoLuongTon()
        {
            string? selected = cboGiay.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selected) || !selected.Contains("_"))
            {
                lblSoLuongHienTai.Text = "0";              // Số lượng tồn kho ban đầu
                lblSoLuongTonKho.Text = "0";              // Số lượng còn lại tạm thời sau khi bán
                numSoLuongBan.Maximum = 0;
                numSoLuongBan.Value = 0;
                numDonGiaBan.Value = 0;
                return;
            }

            var parts = selected.Split('_');
            int giayID = int.Parse(parts[0]);
            int mauID = int.Parse(parts[1]);
            int size = int.Parse(parts[2]);

            var sizeGiay = context.SizeGiays
                .Include(sg => sg.Giay)
                .FirstOrDefault(sg => sg.GiayID == giayID && sg.MauSacID == mauID && sg.Size == size);

            if (sizeGiay != null)
            {
                int tonKhoGoc = sizeGiay.SoLuongTon;
                int daBanTamThoi = 0;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    int rowGiayID = Convert.ToInt32(row.Cells["GiayID"].Value);
                    int rowMauID = Convert.ToInt32(row.Cells["MauSacID"].Value);
                    int rowSize = Convert.ToInt32(row.Cells["colSize"].Value);

                    if (rowGiayID == giayID && rowMauID == mauID && rowSize == size)
                    {
                        int rowSoLuong = Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                        daBanTamThoi += rowSoLuong;
                    }
                }

                int tonSauKhiTruTamThoi = Math.Max(0, tonKhoGoc - daBanTamThoi);
                lblSoLuongTonKho.Text = tonKhoGoc.ToString();                 // tồn kho hiện tại
                lblSoLuongHienTai.Text = tonSauKhiTruTamThoi.ToString();        // còn lại sau bán

                numSoLuongBan.Maximum = tonSauKhiTruTamThoi;
                numSoLuongBan.Value = tonSauKhiTruTamThoi > 0 ? 1 : 0;
                numDonGiaBan.Value = sizeGiay.Giay.GiaBan;
            }
            else
            {
                lblSoLuongHienTai.Text = "0";
                lblSoLuongTonKho.Text = "0";
                numSoLuongBan.Maximum = 0;
                numSoLuongBan.Value = 0;
                numDonGiaBan.Value = 0;
            }
        }



        public void LayGiayVaoComboBox(List<string>? danhSachGiuLai = null)
        {
            int idLoai = Convert.ToInt32(cboLoaiGiay.SelectedValue);
            int idMau = Convert.ToInt32(cboMauSac.SelectedValue);
            int idSize = Convert.ToInt32(cboSize.SelectedValue);

            var query = context.SizeGiays
                .Include(sg => sg.Giay).ThenInclude(g => g.LoaiGiay)
                .Include(sg => sg.MauSac)
                .AsQueryable();

            if (idLoai != 0)
                query = query.Where(sg => sg.Giay.LoaiGiayID == idLoai);

            if (idMau != 0)
                query = query.Where(sg => sg.MauSacID == idMau);

            if (idSize != 0)
                query = query.Where(sg => sg.Size == idSize);

            // Lọc theo checkbox Giày còn hàng
            if (chkConHang.Checked)
                query = query.Where(sg => sg.SoLuongTon > 0);

            var danhSach = query.Select(sg => new
            {
                ID = sg.GiayID + "_" + sg.MauSacID + "_" + sg.Size,
                Display = $"{sg.Giay.TenGiay} - {sg.Giay.LoaiGiay.TenLoai} - {sg.MauSac.TenMau} - Size {sg.Size} (SL: {sg.SoLuongTon})"
            }).ToList();

            // Giữ lại các mục đã chọn trước đó
            if (danhSachGiuLai != null)
            {
                foreach (string key in danhSachGiuLai)
                {
                    if (!danhSach.Any(x => x.ID == key))
                    {
                        var parts = key.Split('_');
                        int giayID = int.Parse(parts[0]);
                        int mauID = int.Parse(parts[1]);
                        int size = int.Parse(parts[2]);

                        var sg = context.SizeGiays
                            .Include(s => s.Giay).ThenInclude(g => g.LoaiGiay)
                            .Include(s => s.MauSac)
                            .FirstOrDefault(s => s.GiayID == giayID && s.MauSacID == mauID && s.Size == size);

                        if (sg != null)
                        {
                            danhSach.Add(new
                            {
                                ID = key,
                                Display = $"{sg.Giay.TenGiay} - {sg.Giay.LoaiGiay.TenLoai} - {sg.MauSac.TenMau} - Size {sg.Size} (SL: {sg.SoLuongTon})"
                            });
                        }
                    }
                }
            }

            cboGiay.DataSource = danhSach;
            cboGiay.ValueMember = "ID";
            cboGiay.DisplayMember = "Display";
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboGiay.Text = "";
                numDonGiaBan.Value = 0;
                numSoLuongBan.Value = 1;
            }
            btnLuu.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView.CurrentRow;

            if (selectedRow.Cells["GiayID"].Value == null ||
                selectedRow.Cells["MauSacID"].Value == null ||
                selectedRow.Cells["colSize"].Value == null ||
                selectedRow.Cells["SoLuongBan"].Value == null)
            {
                MessageBox.Show("Dữ liệu dòng không hợp lệ.");
                return;
            }

            int idGiay = Convert.ToInt32(selectedRow.Cells["GiayID"].Value);
            int mauSacID = Convert.ToInt32(selectedRow.Cells["MauSacID"].Value);
            int size = Convert.ToInt32(selectedRow.Cells["colSize"].Value);
            int soLuongBan = Convert.ToInt32(selectedRow.Cells["SoLuongBan"].Value);

            // Tìm lại tồn kho thật từ CSDL để cộng đúng
            var sizeGiay = context.SizeGiays
                .FirstOrDefault(sg => sg.GiayID == idGiay && sg.Size == size && sg.MauSacID == mauSacID);

            if (sizeGiay == null)
            {
                MessageBox.Show("Không tìm thấy thông tin tồn kho để cập nhật.");
                return;
            }

            // Cộng lại số lượng vào tồn kho tạm thời (label)
            int tongSoLuongDaChon = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row == selectedRow || row.IsNewRow) continue;

                if (row.Cells["GiayID"].Value != null &&
                    row.Cells["colSize"].Value != null &&
                    row.Cells["MauSacID"].Value != null &&
                    (int)row.Cells["GiayID"].Value == idGiay &&
                    (int)row.Cells["colSize"].Value == size &&
                    (int)row.Cells["MauSacID"].Value == mauSacID)
                {
                    tongSoLuongDaChon += Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                }
            }

            // Tính lại số lượng tồn còn lại và hiển thị lại
            int soLuongTonConLai = sizeGiay.SoLuongTon - tongSoLuongDaChon;
            lblSoLuongHienTai.Text = soLuongTonConLai.ToString();

            // Xóa dòng
            dataGridView.Rows.Remove(selectedRow);

            // Đặt lại giá trị cho ComboBox để hiển thị lại giày vừa xóa
            string selectedKey = $"{idGiay}_{mauSacID}_{size}";
            cboGiay.SelectedValue = selectedKey;

            // Gọi lại hàm để cập nhật số lượng tồn theo ComboBox
            CapNhatSoLuongTon();
            TinhTongTien();
        }

        private void LoadThongTinHoaDon(int hoaDonID)
        {
            var hoaDon = context.HoaDons
                .Include(h => h.KhachHang)
                .Include(h => h.NhanVien)
                .Include(h => h.HoaDon_ChiTiets)
                    .ThenInclude(ct => ct.SizeGiay)
                        .ThenInclude(sg => sg.Giay)
                .Include(h => h.HoaDon_ChiTiets)
                    .ThenInclude(ct => ct.SizeGiay)
                        .ThenInclude(sg => sg.MauSac)
                .FirstOrDefault(h => h.ID == hoaDonID);

            if (hoaDon == null) return;

            var giayDaBan = hoaDon.HoaDon_ChiTiets
                .Select(ct => $"{ct.SizeGiay.GiayID}_{ct.SizeGiay.MauSacID}_{ct.SizeGiay.Size}")
                .Distinct()
                .ToList();

            LayGiayVaoComboBox(giayDaBan);

            // Load thông tin chung
            cboKhachHang.SelectedValue = hoaDon.KhachHangID;
            cboNhanVien.SelectedValue = hoaDon.NhanVienID;
            txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

            // Load chi tiết
            foreach (var ct in hoaDon.HoaDon_ChiTiets)
            {
                var rowIndex = dataGridView.Rows.Add();
                var row = dataGridView.Rows[rowIndex];

                row.Cells["GiayID"].Value = ct.SizeGiay.GiayID;
                row.Cells["MauSacID"].Value = ct.SizeGiay.MauSacID;
                row.Cells["colSize"].Value = ct.SizeGiay.Size;
                row.Cells["TenGiay"].Value = ct.SizeGiay.Giay.TenGiay;
                row.Cells["DonGiaBan"].Value = ct.DonGiaBan;
                row.Cells["SoLuongBan"].Value = ct.SoLuongBan;
                row.Cells["ThanhTien"].Value = ct.DonGiaBan * ct.SoLuongBan;
            }
            TinhTongTien();
        }



        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
            LayKhachHangVaoComboBox();
            LayNhanVienVaoComboBox();
            LayLoaiGiayVaoComboBox();
            LayMauSacVaoComboBox();
            LaySizeVaoComboBox();

            if (id != 0)
            {
                LoadThongTinHoaDon(id);
                TinhTongTien();
            }
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            string? selected = cboGiay.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selected) || !selected.Contains("_"))
            {
                MessageBox.Show("Vui lòng chọn giày.");
                return;
            }

            var parts = selected.Split('_');
            int idGiay = int.Parse(parts[0]);
            int mauSacID = int.Parse(parts[1]);
            int size = int.Parse(parts[2]);

            int soLuongNhap = (int)numSoLuongBan.Value;

            var sizeGiay = context.SizeGiays
                .Include(sg => sg.Giay)
                .FirstOrDefault(sg => sg.GiayID == idGiay && sg.Size == size && sg.MauSacID == mauSacID);

            if (sizeGiay == null)
            {
                MessageBox.Show("Không tìm thấy thông tin giày này.");
                return;
            }

            DataGridViewRow? existingRow = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["GiayID"].Value != null &&
                    row.Cells["colSize"].Value != null &&
                    row.Cells["MauSacID"].Value != null &&
                    (int)row.Cells["GiayID"].Value == idGiay &&
                    (int)row.Cells["colSize"].Value == size &&
                    (int)row.Cells["MauSacID"].Value == mauSacID)
                {
                    existingRow = row;
                    break;
                }
            }

            int tongDaChonKhacDongHienTai = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow || row == existingRow) continue;

                if (row.Cells["GiayID"].Value != null &&
                    row.Cells["colSize"].Value != null &&
                    row.Cells["MauSacID"].Value != null &&
                    (int)row.Cells["GiayID"].Value == idGiay &&
                    (int)row.Cells["colSize"].Value == size &&
                    (int)row.Cells["MauSacID"].Value == mauSacID)
                {
                    tongDaChonKhacDongHienTai += Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                }
            }

            int soLuongTonThucTe = sizeGiay.SoLuongTon - tongDaChonKhacDongHienTai;

            if (soLuongTonThucTe <= 0)
            {
                MessageBox.Show("Sản phẩm này đã hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soLuongNhap > soLuongTonThucTe)
            {
                MessageBox.Show($"Số lượng bán vượt quá số lượng tồn. Chỉ còn lại {soLuongTonThucTe} đôi.");
                return;
            }

            // Sau khi thêm hoặc cập nhật dòng:
            if (existingRow != null)
            {
                existingRow.Cells["SoLuongBan"].Value = soLuongNhap;
                existingRow.Cells["ThanhTien"].Value = soLuongNhap * sizeGiay.Giay.GiaBan;
            }
            else
            {
                int rowIndex = dataGridView.Rows.Add();
                DataGridViewRow newRow = dataGridView.Rows[rowIndex];

                newRow.Cells["GiayID"].Value = idGiay;
                newRow.Cells["MauSacID"].Value = mauSacID;
                newRow.Cells["colSize"].Value = size;
                newRow.Cells["TenGiay"].Value = sizeGiay.Giay.TenGiay;
                newRow.Cells["DonGiaBan"].Value = sizeGiay.Giay.GiaBan;
                newRow.Cells["SoLuongBan"].Value = soLuongNhap;
                newRow.Cells["ThanhTien"].Value = sizeGiay.Giay.GiaBan * soLuongNhap;
            }

            // ❗ Rất quan trọng: bỏ chọn dòng hiện tại
            dataGridView.ClearSelection();

            // ✅ Cập nhật lại số lượng tồn sau bán
            CapNhatSoLuongTon();

            // ✅ Tính lại tổng tiền
            TinhTongTien();

        }

        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            using (var frm = new frmKhachHang())
            {
                frm.ShowDialog(); // Đợi người dùng thao tác xong

                if (frm.KhachHangIDMoi > 0)
                {
                    // Load lại danh sách khách hàng
                    LayKhachHangVaoComboBox();

                    // Chọn khách hàng mới tạo
                    cboKhachHang.SelectedValue = frm.KhachHangIDMoi;
                }
            }
        }


        private void cboGiay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CapNhatSoLuongTon();
        }

        private void cboLoaiGiay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
            CapNhatSoLuongTon();
        }

        private void cboMauSac_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
            CapNhatSoLuongTon();
        }

        private void cboSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
            CapNhatSoLuongTon();
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var thanhTienCell = row.Cells["ThanhTien"].Value;
                if (thanhTienCell != null)
                {
                    tongTien += Convert.ToDecimal(thanhTienCell);
                }
            }

            lblTongTien.Text = tongTien.ToString("N0") + " VND";
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên và khách hàng!");
                return;
            }

            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để lưu.");
                return;
            }

            HoaDon hoaDon;
            if (id != 0) // Sửa hóa đơn cũ
            {
                hoaDon = context.HoaDons.Include(h => h.HoaDon_ChiTiets).FirstOrDefault(h => h.ID == id)!;
                if (hoaDon == null) return;

                // Cộng lại tồn kho cũ
                foreach (var ct in hoaDon.HoaDon_ChiTiets)
                {
                    var sizeGiay = context.SizeGiays.FirstOrDefault(s => s.ID == ct.SizeGiayID);
                    if (sizeGiay != null)
                        sizeGiay.SoLuongTon += ct.SoLuongBan;
                }

                // Xóa chi tiết cũ
                context.HoaDonChiTiets.RemoveRange(hoaDon.HoaDon_ChiTiets);

                // Cập nhật lại thông tin hóa đơn
                hoaDon.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                hoaDon.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                hoaDon.GhiChuHoaDon = txtGhiChuHoaDon.Text;
            }
            else // Tạo mới
            {
                hoaDon = new HoaDon
                {
                    NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue),
                    KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                    NgayLap = DateTime.Now,
                    GhiChuHoaDon = txtGhiChuHoaDon.Text,
                };
                context.HoaDons.Add(hoaDon);
                context.SaveChanges(); // cần để lấy hoaDon.ID
            }

            // Thêm lại chi tiết mới
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                int giayID = Convert.ToInt32(row.Cells["GiayID"].Value);
                int mauSacID = Convert.ToInt32(row.Cells["MauSacID"].Value);
                int size = Convert.ToInt32(row.Cells["colSize"].Value);
                int soLuongBan = Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                int donGia = Convert.ToInt32(row.Cells["DonGiaBan"].Value);

                var sizeGiay = context.SizeGiays.FirstOrDefault(sg =>
                    sg.GiayID == giayID && sg.MauSacID == mauSacID && sg.Size == size);

                if (sizeGiay == null)
                {
                    MessageBox.Show("Không tìm thấy SizeGiay.");
                    return;
                }

                if (sizeGiay.SoLuongTon < soLuongBan)
                {
                    MessageBox.Show($"Sản phẩm {sizeGiay.Giay.TenGiay} không đủ tồn kho.");
                    return;
                }

                sizeGiay.SoLuongTon -= soLuongBan;

                context.HoaDonChiTiets.Add(new HoaDon_ChiTiet
                {
                    HoaDonID = hoaDon.ID,
                    SizeGiayID = sizeGiay.ID,
                    SoLuongBan = soLuongBan,
                    DonGiaBan = donGia
                });
            }

            context.SaveChanges();

            MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.IsNewRow) return;

            int giayID = Convert.ToInt32(dataGridView.CurrentRow.Cells["GiayID"].Value);
            int mauID = Convert.ToInt32(dataGridView.CurrentRow.Cells["MauSacID"].Value);
            int size = Convert.ToInt32(dataGridView.CurrentRow.Cells["colSize"].Value);
            int soLuongDangChon = Convert.ToInt32(dataGridView.CurrentRow.Cells["SoLuongBan"].Value);

            var sizeGiay = context.SizeGiays
                .FirstOrDefault(sg => sg.GiayID == giayID && sg.MauSacID == mauID && sg.Size == size);

            if (sizeGiay != null)
            {
                int tonKhoGoc = sizeGiay.SoLuongTon;
                int daBanTamThoi = 0;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    int rowGiayID = Convert.ToInt32(row.Cells["GiayID"].Value);
                    int rowMauID = Convert.ToInt32(row.Cells["MauSacID"].Value);
                    int rowSize = Convert.ToInt32(row.Cells["colSize"].Value);

                    // Bỏ qua dòng đang chọn
                    if (row.Index == dataGridView.CurrentRow.Index) continue;

                    if (rowGiayID == giayID && rowMauID == mauID && rowSize == size)
                    {
                        int rowSoLuong = Convert.ToInt32(row.Cells["SoLuongBan"].Value);
                        daBanTamThoi += rowSoLuong;
                    }
                }

                int tonSauKhiTruTamThoi = Math.Max(0, tonKhoGoc - daBanTamThoi);

                lblSoLuongTonKho.Text = tonKhoGoc.ToString();
                lblSoLuongHienTai.Text = tonSauKhiTruTamThoi.ToString();

                cboGiay.SelectedValue = $"{giayID}_{mauID}_{size}";

                numSoLuongBan.Maximum = tonSauKhiTruTamThoi;
                numSoLuongBan.Value = Math.Min(soLuongDangChon, tonSauKhiTruTamThoi);

                numDonGiaBan.Value = Convert.ToDecimal(dataGridView.CurrentRow.Cells["DonGiaBan"].Value);
            }
            else
            {
                lblSoLuongTonKho.Text = "0";
                lblSoLuongHienTai.Text = "0";

                numSoLuongBan.Maximum = 0;
                numSoLuongBan.Value = 0;
                numDonGiaBan.Value = 0;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (frmInHoaDon frm = new frmInHoaDon(id))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng lưu hóa đơn trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkConHang_CheckedChanged(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
        }
    }
}