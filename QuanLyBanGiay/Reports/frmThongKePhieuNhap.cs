using Microsoft.Reporting.WinForms;
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
using static QuanLyBanGiay.Reports.QLBGDataSet;

namespace QuanLyBanGiay.Reports
{
    public partial class frmThongKePhieuNhap : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLBGDataSet.DanhSachPhieuNhapDataTable danhSachPhieuNhapDataTable = new QLBGDataSet.DanhSachPhieuNhapDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKePhieuNhap()
        {
            InitializeComponent();
        }

        private void frmThongKePhieuNhap_Load(object sender, EventArgs e)
        {
            var danhSachPhieuNhap = context.PhieuNhaps.Select(r => new
            {
                r.ID,
                r.NhanVienID,
                r.NhanVien.HoVaTen,
                r.NhaCungCapID,
                r.NhaCungCap.TenNhaCungCap,
                r.NgayNhap,
                r.GhiChu,
                TongTienPhieuNhap = r.PhieuNhapChiTiets.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap)
            }).ToList();
            danhSachPhieuNhapDataTable.Clear();
            foreach (var row in danhSachPhieuNhap)
            {
                danhSachPhieuNhapDataTable.AddDanhSachPhieuNhapRow(
                    row.ID,
                    row.NhanVienID,
                    row.HoVaTen,
                    row.NhaCungCapID,
                    row.TenNhaCungCap,
                    row.NgayNhap,
                    row.GhiChu,
                    row.TongTienPhieuNhap);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsPhieuNhap";
            reportDataSource.Value = danhSachPhieuNhapDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource); reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKePhieuNhap.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachPhieuNhap = context.PhieuNhaps.Select(r => new
            {
                r.ID,
                r.NhanVienID,
                r.NhanVien.HoVaTen,
                r.NhaCungCapID,
                r.NhaCungCap.TenNhaCungCap,
                r.NgayNhap,
                r.GhiChu,
                TongTienPhieuNhap = r.PhieuNhapChiTiets.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap)
            }).Where(r => r.NgayNhap >= dtpTuNgay.Value.Date && r.NgayNhap < dtpDenNgay.Value.Date.AddDays(1)).ToList();

            danhSachPhieuNhapDataTable.Clear();
            foreach (var row in danhSachPhieuNhap)
            {
                danhSachPhieuNhapDataTable.AddDanhSachPhieuNhapRow(
                    row.ID,
                    row.NhanVienID,
                    row.HoVaTen,
                    row.NhaCungCapID,
                    row.TenNhaCungCap,
                    row.NgayNhap,
                    row.GhiChu,
                    row.TongTienPhieuNhap);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsPhieuNhap";
            reportDataSource.Value = danhSachPhieuNhapDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource); reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKePhieuNhap.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày: " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKePhieuNhap_Load(sender, e);
        }
    }
}
