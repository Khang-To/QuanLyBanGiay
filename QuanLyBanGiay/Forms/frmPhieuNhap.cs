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
    public partial class frmPhieuNhap : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id;
        public frmPhieuNhap()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        public void BatTatChucNang()
        {
            // Nút In hóa đơn, Sửa và Xóa chỉ sáng khi có hóa đơn
            btnInPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                var pn = context.PhieuNhaps.Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.NhaCungCapID,
                    r.NhaCungCap.TenNhaCungCap,
                    r.NgayNhap,
                    r.GhiChu,
                    TongTienPhieuNhap = r.PhieuNhapChiTiets.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = pn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BatTatChucNang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmPhieuNhap_ChiTiet chiTiet = new frmPhieuNhap_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmPhieuNhap_ChiTiet chiTiet = new frmPhieuNhap_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa phiếu nhập đang chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    PhieuNhap pn = context.PhieuNhaps.Find(id)!;
                    if (pn != null)
                    {
                        // Xóa toàn bộ chi tiết phiếu nhập
                        var chiTietList = context.PhieuNhapChiTiets.Where(r => r.PhieuNhapID == id).ToList();
                        context.PhieuNhapChiTiets.RemoveRange(chiTietList);

                        // Xóa hóa đơn
                        context.PhieuNhaps.Remove(pn);
                        context.SaveChanges();
                    }
                    frmPhieuNhap_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                btnSua_Click(sender, e);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //Mở hộp thoại mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu vào tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                    {
                        #region Xử lý sheet hóa đơn (Sheet 1)
                        IXLWorksheet sheet1 = wb.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable tablePhieuNhap = new DataTable();

                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    tablePhieuNhap.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tablePhieuNhap.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    tablePhieuNhap.Rows[tablePhieuNhap.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        //Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tablePhieuNhap.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow row in tablePhieuNhap.Rows)
                                {
                                    PhieuNhap pn = new PhieuNhap();
                                    pn.ID = Convert.ToInt32(row["ID"].ToString());
                                    pn.NhaCungCapID = Convert.ToInt32(row["NhaCungCapID"].ToString());
                                    pn.NhanVienID = Convert.ToInt32(row["NhanVienID"].ToString());
                                    pn.NgayNhap = Convert.ToDateTime(row["NgayNhap"].ToString());
                                    pn.GhiChu = row["GhiChu"].ToString();
                                    context.PhieuNhaps.Add(pn);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhaps ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhaps OFF");
                                transaction.Commit();
                            }
                        }
                        #endregion

                        #region Xử lý sheet hóa đơn chi tiết (Sheet 2)
                        IXLWorksheet sheet2 = wb.Worksheet(2);
                        bool firstRowChiTiet = true;
                        string readRangeChiTiet = "1:1";
                        DataTable tablePhieuNhap_ChiTiet = new DataTable();

                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet2.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowChiTiet)
                            {
                                readRangeChiTiet = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeChiTiet))
                                    tablePhieuNhap_ChiTiet.Columns.Add(cell.Value.ToString());
                                firstRowChiTiet = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tablePhieuNhap_ChiTiet.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeChiTiet))
                                {
                                    tablePhieuNhap_ChiTiet.Rows[tablePhieuNhap_ChiTiet.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        //Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tablePhieuNhap_ChiTiet.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow row in tablePhieuNhap_ChiTiet.Rows)
                                {
                                    PhieuNhap_ChiTiet pnct = new PhieuNhap_ChiTiet();
                                    pnct.ID = Convert.ToInt32(row["ID"].ToString());
                                    pnct.PhieuNhapID = Convert.ToInt32(row["PhieuNhapID"].ToString());
                                    pnct.SizeGiayID = Convert.ToInt32(row["SizeGiayID"].ToString());
                                    pnct.SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"].ToString());
                                    pnct.DonGiaNhap = Convert.ToInt32(row["DonGiaNhap"].ToString());
                                    context.PhieuNhapChiTiets.Add(pnct);

                                    // Cập nhật tồn kho trong bảng SizeGiay
                                    var size = context.SizeGiays.FirstOrDefault(s => s.ID == pnct.SizeGiayID);
                                    if (size != null)
                                    {
                                        size.SoLuongTon += pnct.SoLuongNhap;
                                    }
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhap_ChiTiets ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhap_ChiTiets OFF");
                                transaction.Commit();
                            }
                            MessageBox.Show("Đã nhập thành công " + tablePhieuNhap.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmPhieuNhap_Load(sender, e);
                        }
                        #endregion

                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            //Mở hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "PhieuNhap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Xuất dữ liệu hóa đơn ra sheet 1 (HoaDon)
                    DataTable tablePhieuNhap = new DataTable();
                    tablePhieuNhap.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhanVienID", typeof(int)),
                        new DataColumn("NhaCungCapID", typeof(int)),
                        new DataColumn("NgayNhap", typeof(DateTime)),
                        new DataColumn("GhiChu", typeof(string))
                    });

                    var pn = context.PhieuNhaps.ToList();
                    if (pn != null)
                    {
                        foreach (var p in pn)
                            tablePhieuNhap.Rows.Add(p.ID, p.NhanVienID, p.NhaCungCapID, p.NgayNhap, p.GhiChu);
                    }

                    //Xuất dữ liệu hóa đơn chi tiết ra sheet 2 (HoaDon_ChiTiet)
                    DataTable tablePhieuNhap_ChiTiet = new DataTable();
                    tablePhieuNhap_ChiTiet.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("PhieuNhapID", typeof(int)),
                        new DataColumn("SizeGiayID", typeof(int)),
                        new DataColumn("SoLuongNhap", typeof(int)),
                        new DataColumn("DonGiaNhap", typeof(int)),
                    });

                    var ct = context.PhieuNhapChiTiets.ToList();
                    if (ct != null)
                    {
                        foreach (var c in ct)
                            tablePhieuNhap_ChiTiet.Rows.Add(c.ID, c.PhieuNhapID, c.SizeGiayID, c.SoLuongNhap, c.DonGiaNhap);
                    }

                    //Lưu vào excel
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        //lưu hóa đơn vào sheet 1
                        var sheet1 = wb.Worksheets.Add(tablePhieuNhap, "Phiếu nhập");
                        sheet1.Columns().AdjustToContents();

                        //lưu chi tiết hóa đơn vào sheet 2
                        var sheet2 = wb.Worksheets.Add(tablePhieuNhap_ChiTiet, "Chi Tiết Phiếu nhập");
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
            var pn = context.PhieuNhaps
                .Where(r => r.NhaCungCap.TenNhaCungCap.Contains(txtTuKhoa.Text) || r.NhanVien.HoVaTen.Contains(txtTuKhoa.Text))
                .Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.NhaCungCapID,
                    r.NhaCungCap.TenNhaCungCap,
                    r.NgayNhap,
                    r.GhiChu,
                    TongTienHoaDon = r.PhieuNhapChiTiets.Sum(r => (r.SoLuongNhap) * (r.DonGiaNhap)),
                    XemChiTiet = "Xem chi tiết"
                })
                .ToList();
            dataGridView.DataSource = pn;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmPhieuNhap_Load(sender,e);
            txtTuKhoa.Text = "";
        }
    }
}
