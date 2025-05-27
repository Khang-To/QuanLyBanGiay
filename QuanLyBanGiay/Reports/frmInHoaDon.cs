using Microsoft.EntityFrameworkCore;
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
    public partial class frmInHoaDon : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLBGDataSet.DanhSachHoaDon_ChiTietDataTable dsHoaDon_ChiTietDataTable = new QLBGDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id;
        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDons
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDon_ChiTiets)
                .ThenInclude(ct => ct.SizeGiay)
                .ThenInclude(sg => sg.Giay)
                .SingleOrDefault(r => r.ID == id);

            if (hoaDon != null)
            {
                var hoaDonChiTiet = context.HoaDonChiTiets
                    .Where(r => r.HoaDonID == id)
                    .Include(r => r.SizeGiay)
                        .ThenInclude(sg => sg.Giay)
                    .Select(r => new
                    {
                        r.ID,
                        r.HoaDonID,
                        SizeGiayID = r.SizeGiayID,
                        TenGiay = r.SizeGiay.Giay.TenGiay,
                        Size = r.SizeGiay.Size,
                        r.SoLuongBan,
                        r.DonGiaBan,
                        ThanhTien = r.SoLuongBan * r.DonGiaBan
                    })
                    .ToList();

                dsHoaDon_ChiTietDataTable.Clear();
                foreach (var row in hoaDonChiTiet)
                {
                    dsHoaDon_ChiTietDataTable.AddDanhSachHoaDon_ChiTietRow(
                        row.ID,
                        row.HoaDonID,
                        row.SizeGiayID,
                        row.TenGiay,
                        row.Size,
                        row.SoLuongBan,
                        row.DonGiaBan,
                        row.ThanhTien
                    );
                }

                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "dsHoaDonChiTiet",
                    Value = dsHoaDon_ChiTietDataTable
                };

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

                IList<ReportParameter> param = new List<ReportParameter>
        {
            new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}", hoaDon.NgayLap.Day, hoaDon.NgayLap.Month, hoaDon.NgayLap.Year)),
            new ReportParameter("NguoiBan_Ten", "BLUE EAGLE STORE"),
            new ReportParameter("NguoiBan_DiaChi", "Mỹ Thạnh, TP. Long Xuyên, An Giang"),
            new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.HoVaTen),
            new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChi),
            new ReportParameter("TongTien", hoaDon.HoaDon_ChiTiets.Sum(r => r.SoLuongBan * r.DonGiaBan).ToString())
                };

                reportViewer.LocalReport.SetParameters(param);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }

    }
}
