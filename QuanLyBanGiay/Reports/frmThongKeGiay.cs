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
    public partial class frmThongKeGiay : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLBGDataSet.DanhSachGiayDataTable dsGiayDataTable = new QLBGDataSet.DanhSachGiayDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeGiay()
        {
            InitializeComponent();
        }

        private void frmThongKeGiay_Load(object sender, EventArgs e)
        {
            var dsGiay = context.SizeGiays.Select(r=> new
            {
                r.ID,
                r.GiayID,
                r.Giay.ThuongHieu.TenThuongHieu,
                r.Giay.LoaiGiay.TenLoai,
                r.Giay.TenGiay,
                r.MauSacID,
                r.MauSac.TenMau,
                r.Size,
                r.Giay.GiaBan,
                r.SoLuongTon
                }).ToList();  
            
            dsGiayDataTable.Clear();
            foreach(var row in dsGiay)
            {
                dsGiayDataTable.AddDanhSachGiayRow(
                    row.ID,
                    row.GiayID, 
                    row.TenThuongHieu, 
                    row.TenLoai, 
                    row.TenGiay, 
                    row.MauSacID, 
                    row.TenMau, 
                    row.Size,
                    row.GiaBan, 
                    row.SoLuongTon);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsGiay";
            reportDataSource.Value = dsGiayDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeGiay.rdlc");
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }
    }
}
