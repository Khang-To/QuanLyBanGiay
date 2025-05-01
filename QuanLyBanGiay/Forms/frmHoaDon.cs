using ClosedXML.Excel;
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
    public partial class frmHoaDon : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id = 0;
        public frmHoaDon()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        public void BatTatChucNang()
        {
            btnInHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                var hd = context.HoaDons.Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLap,
                    r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiets.Sum(r =>
                    r.SoLuongBan * r.DonGiaBan),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = hd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BatTatChucNang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận hóa đơn đang chọn", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    HoaDon hd = context.HoaDons.Find(id)!;
                    if (hd != null)
                    {
                        HoaDon_ChiTiet ct = context.HoaDonChiTiets.Where(r =>
                        r.HoaDonID == id).SingleOrDefault()!;
                        context.HoaDonChiTiets.Remove(ct);

                        context.HoaDons.Remove(hd);
                        context.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
            txtTuKhoa.Clear();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.Title = "Chọn tập tin Excel";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        #region Sheet1
                        IXLWorksheet sheet1 = workbook.Worksheet(1);
                        bool firstRowHoaDon = true;
                        string readRangeHoaDon = "1:1";
                        DataTable tableHoaDon = new DataTable();
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            if (firstRowHoaDon)
                            {
                                readRangeHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                    tableHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowHoaDon = false;
                            }
                            else
                            {
                                tableHoaDon.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                {
                                    tableHoaDon.Rows[tableHoaDon.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (tableHoaDon.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableHoaDon.Rows)
                                {
                                    HoaDon hd = new HoaDon();
                                    hd.ID = Convert.ToInt32(r["ID"].ToString());
                                    hd.NhanVienID = Convert.ToInt32(r["NhanVienID"].ToString());
                                    hd.KhachHangID = Convert.ToInt32(r["KhachHangID"].ToString());
                                    hd.NgayLap = Convert.ToDateTime(r["NgayLap"].ToString());
                                    hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();
                                    context.HoaDons.Add(hd);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon OFF");
                                transaction.Commit();
                            }
                        }
                        #endregion
                        #region Sheet2
                        IXLWorksheet sheet2 = workbook.Worksheet(2);
                        bool firstRowChiTietHoaDon = true;
                        string readRangeChiTietHoaDon = "1:1";
                        DataTable tableChiTietHoaDon = new DataTable();
                        foreach (IXLRow row in sheet2.RowsUsed())
                        {
                            if (firstRowChiTietHoaDon)
                            {
                                readRangeChiTietHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                    tableChiTietHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowChiTietHoaDon = false;
                            }
                            else
                            {
                                tableChiTietHoaDon.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                {
                                    tableChiTietHoaDon.Rows[tableChiTietHoaDon.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (tableChiTietHoaDon.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableChiTietHoaDon.Rows)
                                {
                                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                                    ct.ID = Convert.ToInt32(r["ID"].ToString());
                                    ct.HoaDonID = Convert.ToInt32(r["HoaDonID"].ToString());
                                    ct.SanPhamID = Convert.ToInt32(r["SanPhamID"].ToString());
                                    ct.SoLuongBan = Convert.ToInt32(r["SoLuongBan"].ToString());
                                    ct.DonGiaBan = Convert.ToInt32(r["DonGiaBan"].ToString());
                                    context.HoaDonChiTiets.Add(ct);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon_ChiTiet ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon_ChiTiet OFF");
                                transaction.Commit();
                            }
                            MessageBox.Show("Nhập dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
                        #endregion
                        if (firstRowHoaDon)
                        {
                            MessageBox.Show("Không có dữ liệu để nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable tableHoaDon = new DataTable();
                    tableHoaDon.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("NhanVienID", typeof(int)),
                    new DataColumn("KhachHangID", typeof(int)),
                    new DataColumn("NgayLap", typeof(DateTime)),
                    new DataColumn("GhiChuHoaDon", typeof(string))
                    }); var hd = context.HoaDons.ToList();
                    if (hd != null)
                    {
                        foreach (var p in hd)
                            tableHoaDon.Rows.Add(p.ID, p.NhanVienID, p.KhachHangID, p.NgayLap, p.GhiChuHoaDon);
                    }
                    DataTable tableHoaDonChiTiet = new DataTable();
                    tableHoaDonChiTiet.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("HoaDonID", typeof(int)),
                    new DataColumn("SanPhamID", typeof(int)),
                    new DataColumn("SoLuongBan", typeof(int)),
                    new DataColumn("DonGiaBan", typeof(int))
                    });
                    var ct = context.HoaDonChiTiets.ToList();
                    if (ct != null)
                    {
                        foreach (var p in ct)
                            tableHoaDonChiTiet.Rows.Add(p.ID, p.HoaDonID, p.SanPhamID, p.SoLuongBan, p.DonGiaBan);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableHoaDon, "HoaDon");
                        sheet1.Columns().AdjustToContents();
                        var sheet2 = wb.Worksheets.Add(tableHoaDonChiTiet, "HoaDon_ChiTiet");
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var hd = context.HoaDons
                .Where(p => p.NhanVien.HoVaTen.Contains(txtTuKhoa.Text) || p.KhachHang.HoVaTen.Contains(txtTuKhoa.Text)).Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLap,
                    r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiets.Sum(r =>
                    r.SoLuongBan * r.DonGiaBan),
                    XemChiTiet = "Xem chi tiết"
                })
                .ToList();
            dataGridView.DataSource = hd;
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
                btnSua_Click(sender, e);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
