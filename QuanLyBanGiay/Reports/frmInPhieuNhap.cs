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
    public partial class frmInPhieuNhap : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLBGDataSet.DanhSachPhieuNhap_ChiTietDataTable danhSachPhieuNhap_ChiTietDataTable = new QLBGDataSet.DanhSachPhieuNhap_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id; // Mã hóa đơn

        public frmInPhieuNhap(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            var pn = context.PhieuNhaps
                            .Include(p => p.NhanVien)
                            .Include(p => p.NhaCungCap)
                            .Include(p => p.PhieuNhapChiTiets)
                                .ThenInclude(ct => ct.SizeGiay)
                                    .ThenInclude(sg => sg.Giay)
                            .Include(p => p.PhieuNhapChiTiets)
                                .ThenInclude(ct => ct.SizeGiay)
                                    .ThenInclude(sg => sg.MauSac)
                            .Where(p => p.ID == id)
                            .SingleOrDefault();

            if (pn != null)
            {
                var chiTiet = pn.PhieuNhapChiTiets.Select(ct => new
                {
                    ct.ID,
                    ct.PhieuNhapID,
                    ct.SizeGiayID,
                    TenGiay = ct.SizeGiay.Giay.TenGiay,
                    TenMau = ct.SizeGiay.MauSac.TenMau,
                    Size = ct.SizeGiay.Size,
                    SoLuongNhap = ct.SoLuongNhap,
                    DonGiaNhap = ct.DonGiaNhap,
                    ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap
                }).ToList();

                danhSachPhieuNhap_ChiTietDataTable.Clear();
                foreach (var item in chiTiet)
                {
                    danhSachPhieuNhap_ChiTietDataTable.AddDanhSachPhieuNhap_ChiTietRow(
                        item.ID,
                        item.PhieuNhapID,
                        item.SizeGiayID,
                        item.TenGiay,
                        item.TenMau,
                        item.Size,
                        item.SoLuongNhap,
                        item.DonGiaNhap,
                        item.ThanhTien
                    );
                }

                // Gán dữ liệu vào report
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsPhieuNhap_ChiTiet";
                reportDataSource.Value = danhSachPhieuNhap_ChiTietDataTable;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhieuNhap.rdlc");

                // Gán parameter
                IList<ReportParameter> parameters = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}",pn.NgayNhap.Day, pn.NgayNhap.Month, pn.NgayNhap.Year)),
                    new ReportParameter("SoPhieu", "Số phiếu: " + pn.ID.ToString()),
                    new ReportParameter("NhaCungCap_Ten", pn.NhaCungCap.TenNhaCungCap),
                    new ReportParameter("NhaCungCap_DiaChi", pn.NhaCungCap.DiaChi ?? ""),
                    new ReportParameter("NhaCungCap_MaSoThue", "1602162070"),
                    new ReportParameter("NhanVien_Ten", pn.NhanVien.HoVaTen),
                    new ReportParameter("CuaHang_DiaChi", "Trường Đại học An Giang")
                };

                reportViewer1.LocalReport.SetParameters(parameters);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }
    }
}
