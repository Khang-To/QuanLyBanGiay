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
    public partial class frmThongKeDoanhThu : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLBGDataSet.DanhSachHoaDonDataTable dsHoaDon = new QLBGDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var hoaDonList = context.HoaDons.Select(hd => new
            {
                hd.ID,
                hd.NhanVienID,
                HoVaTenNhanVien = hd.NhanVien.HoVaTen,
                hd.KhachHangID,
                HoVaTenKhachHang = hd.KhachHang.HoVaTen,
                hd.NgayLap,
                hd.GhiChuHoaDon,
                TongTienHoaDon = hd.HoaDon_ChiTiets.Sum(ct => ct.SoLuongBan * ct.DonGiaBan)
            }).ToList();
            dsHoaDon.Clear();
            foreach (var row in hoaDonList)
            {
                dsHoaDon.AddDanhSachHoaDonRow(
                row.ID,
                row.NhanVienID,
                row.HoVaTenNhanVien,
                row.KhachHangID,
                row.HoVaTenKhachHang,
                row.NgayLap,
                row.GhiChuHoaDon ?? "",
                row.TongTienHoaDon
                 );
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = dsHoaDon;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource); reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var hoaDonList = context.HoaDons.Select(hd => new
            {
                hd.ID,
                hd.NhanVienID,
                HoVaTenNhanVien = hd.NhanVien.HoVaTen,
                hd.KhachHangID,
                HoVaTenKhachHang = hd.KhachHang.HoVaTen,
                hd.NgayLap,
                hd.GhiChuHoaDon,
                TongTienHoaDon = hd.HoaDon_ChiTiets.Sum(ct => ct.SoLuongBan * ct.DonGiaBan)
            }).Where(r => r.NgayLap >= dtpTuNgay.Value.Date && r.NgayLap < dtpDenNgay.Value.Date.AddDays(1)).ToList();

            dsHoaDon.Clear();
            foreach (var row in hoaDonList)
            {
                dsHoaDon.AddDanhSachHoaDonRow(
               row.ID,
               row.NhanVienID,
               row.HoVaTenNhanVien,
               row.KhachHangID,
               row.HoVaTenKhachHang,
               row.NgayLap,
               row.GhiChuHoaDon ?? "",
               row.TongTienHoaDon
                );
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = dsHoaDon;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource); reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày: " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}
        