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

        private void LayLoaiGiayVaoComboBox()
        {
            cboLoaiGiay.DataSource = context.LoaiGiays.ToList();
            cboLoaiGiay.DisplayMember = "TenLoai";
            cboLoaiGiay.ValueMember = "ID";
        }

        private void LayThuongHieuVaoComboBox()
        {
            cboThuongHieu.DataSource = context.ThuongHieus.ToList();
            cboThuongHieu.DisplayMember = "TenThuongHieu";
            cboThuongHieu.ValueMember = "ID";
        }

        private void frmThongKeGiay_Load(object sender, EventArgs e)
        {
            LayLoaiGiayVaoComboBox();
            LayThuongHieuVaoComboBox();
            var dsGiay = context.SizeGiays.Select(r => new
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
            foreach (var row in dsGiay)
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
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sản phẩm)");
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboLoaiGiay.Text == "" && cboThuongHieu.Text == "")
            {
                frmThongKeGiay_Load(sender, e);
            }
            else
            {
                var dsGiay = context.SizeGiays.Select(r => new
                {
                    r.ID,
                    r.GiayID,
                    r.Giay.ThuongHieuID,
                    r.Giay.ThuongHieu.TenThuongHieu,
                    r.Giay.LoaiGiayID,
                    r.Giay.LoaiGiay.TenLoai,
                    r.Giay.TenGiay,
                    r.MauSacID,
                    r.MauSac.TenMau,
                    r.Size,
                    r.Giay.GiaBan,
                    r.SoLuongTon
                });

                string thuongHieu = null;
                string loaiGiay = null;

                if (cboThuongHieu.Text != "")
                {
                    int thuongHieuID = Convert.ToInt32(cboThuongHieu.SelectedValue?.ToString());
                    thuongHieu = "Thương hiệu: " + cboThuongHieu.Text;
                    dsGiay = dsGiay.Where(r => r.ThuongHieuID == thuongHieuID);
                }
                if (cboLoaiGiay.Text != "")
                {
                    int loaiGiayID = Convert.ToInt32(cboLoaiGiay.SelectedValue?.ToString());
                    loaiGiay += "Loại giày: " + cboLoaiGiay.Text;
                    dsGiay = dsGiay.Where(r => r.LoaiGiayID == loaiGiayID);
                }

                dsGiayDataTable.Clear();
                foreach (var row in dsGiay)
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
                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + thuongHieu + " - " + loaiGiay + ")");
                reportViewer.LocalReport.SetParameters(reportParameter);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.PageWidth;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLoaiGiay.SelectedIndex = -1;
            cboThuongHieu.SelectedIndex = -1;
            frmThongKeGiay_Load(sender, e);
        }
    }
}
