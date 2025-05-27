using ClosedXML.Excel;
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
    public partial class frmHoaDon : Form
    {
        frmHoaDon_ChiTiet? frmHoaDon_ChiTiet = null;
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
                    TongTienHoaDon = r.HoaDon_ChiTiets.Sum(r => (r.SoLuongBan) * r.DonGiaBan),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = hd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BatTatChucNang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmHoaDon_ChiTiet == null || frmHoaDon_ChiTiet.IsDisposed)
            {
                var frmChiTiet = new frmHoaDon_ChiTiet();
                frmChiTiet.MdiParent = this.MdiParent;
                frmChiTiet.Show();

            }
            else
            {
                frmHoaDon_ChiTiet.Activate();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Index >= 0)
            {
                int hoaDonID = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                frmHoaDon_ChiTiet frmChiTiet = new frmHoaDon_ChiTiet(hoaDonID);
                frmChiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa hóa đơn đang chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    var hd = context.HoaDons.Find(id);
                    if (hd != null)
                    {
                        // Xóa chi tiết trước
                        var chiTietList = context.HoaDonChiTiets.Where(ct => ct.HoaDonID == id).ToList();
                        context.HoaDonChiTiets.RemoveRange(chiTietList);

                        // Xóa hóa đơn
                        context.HoaDons.Remove(hd);

                        context.SaveChanges();
                    }

                    frmHoaDon_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        IXLWorksheet sheet1 = workbook.Worksheet(1);
                        bool firstRowHoaDon = true;
                        string readRangeHoaDon = "1:1";
                        DataTable tableHoaDon = new DataTable();
                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowHoaDon)
                            {
                                readRangeHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                    tableHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowHoaDon = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
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
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
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
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDons ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDons OFF");
                                transaction.Commit();
                            }
                        }
                        IXLWorksheet sheet2 = workbook.Worksheet(2);
                        bool firstRowChiTietHoaDon = true;
                        string readRangeChiTietHoaDon = "1:1";
                        DataTable tableChiTietHoaDon = new DataTable();
                        // Đọc Sheet 2 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet2.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowChiTietHoaDon)
                            {
                                readRangeChiTietHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                    tableChiTietHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowChiTietHoaDon = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
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
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tableChiTietHoaDon.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableChiTietHoaDon.Rows)
                                {
                                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                                    ct.ID = Convert.ToInt32(r["ID"].ToString());
                                    ct.HoaDonID = Convert.ToInt32(r["HoaDonID"].ToString());
                                    ct.SizeGiayID = Convert.ToInt32(r["SizeGiayID"].ToString());
                                    ct.SoLuongBan = Convert.ToInt32(r["SoLuongBan"].ToString());
                                    ct.DonGiaBan = Convert.ToInt32(r["DonGiaBan"].ToString());
                                    context.HoaDonChiTiets.Add(ct);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDonChiTiets ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDonChiTiets OFF");
                                transaction.Commit();
                            }
                            MessageBox.Show("Nhập dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
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
                    // Xuất dữ liệu Hóa đơn ra Sheet 1 (HoaDon)
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
                    //Xuất dữ liệu Hóa đơn chi tiết ra Sheet 2(HoaDon_ChiTiet)
                    DataTable tableHoaDonChiTiet = new DataTable();
                    tableHoaDonChiTiet.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("HoaDonID", typeof(int)),
                    new DataColumn("SizeGiayID", typeof(int)),
                    new DataColumn("SoLuongBan", typeof(int)),
                    new DataColumn("DonGiaBan", typeof(int))
                    });
                    var ct = context.HoaDonChiTiets.ToList();
                    if (ct != null)
                    {
                        foreach (var p in ct)
                            tableHoaDonChiTiet.Rows.Add(p.ID, p.HoaDonID, p.SizeGiayID, p.SoLuongBan, p.DonGiaBan);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableHoaDon, "HoaDons");
                        sheet1.Columns().AdjustToContents();
                        var sheet2 = wb.Worksheets.Add(tableHoaDonChiTiet, "HoaDon_ChiTiets");
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
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int hoaDonID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(hoaDonID);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
                {
                    inHoaDon.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để in hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
