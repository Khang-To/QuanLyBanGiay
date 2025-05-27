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
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "dsHoaDon", // Tên DataSet trong file .rdlc
                Value = dsHoaDon
            };

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }
    }
}
        