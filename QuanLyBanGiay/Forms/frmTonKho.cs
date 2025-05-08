using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class frmTonKho : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        public frmTonKho()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        public void layLoaiGiayVaoComboBox()
        {
            cboLoaiGiay.ComboBox.DataSource = context.LoaiGiays.ToList();
            cboLoaiGiay.ComboBox.DisplayMember = "TenLoai";
            cboLoaiGiay.ComboBox.ValueMember = "ID";
            cboLoaiGiay.ComboBox.SelectedIndex = -1;
        }

        public void layMauVaoComboBox()
        {
            cboMauSac.ComboBox.DataSource = context.MauSacs.ToList();
            cboMauSac.ComboBox.DisplayMember = "TenMau";
            cboMauSac.ComboBox.ValueMember = "ID";
            cboMauSac.ComboBox.SelectedIndex = -1;
        }

        public void layThuongHieuVaoComboBox()
        {
            cboThuongHieu.ComboBox.DataSource = context.ThuongHieus.ToList();
            cboThuongHieu.ComboBox.DisplayMember = "TenThuongHieu";
            cboThuongHieu.ComboBox.ValueMember = "ID";
            cboThuongHieu.ComboBox.SelectedIndex = -1;
        }

        public void laySizeVaoComboBox()
        {
            cboSizeGiay.ComboBox.DataSource = context.SizeGiays
                .Select(s => s.Size)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
            cboSizeGiay.ComboBox.SelectedIndex = -1;
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            layLoaiGiayVaoComboBox();
            layThuongHieuVaoComboBox();
            layMauVaoComboBox();
            laySizeVaoComboBox();

            var query = from sz in context.SizeGiays
                        join g in context.Giays on sz.GiayID equals g.ID
                        join l in context.LoaiGiays on g.LoaiGiayID equals l.ID
                        join t in context.ThuongHieus on g.ThuongHieuID equals t.ID
                        join m in context.MauSacs on sz.MauSacID equals m.ID
                        select new
                        {
                            ID = sz.ID,
                            TenGiay = g.TenGiay,
                            TenThuongHieu = t.TenThuongHieu,
                            TenLoai = l.TenLoai,
                            TenMau = m.TenMau,
                            Size = sz.Size,
                            SoLuongTon = sz.SoLuongTon
                        };

            dataGridView.DataSource = query.ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query = from sz in context.SizeGiays
                        join g in context.Giays on sz.GiayID equals g.ID
                        join l in context.LoaiGiays on g.LoaiGiayID equals l.ID
                        join t in context.ThuongHieus on g.ThuongHieuID equals t.ID
                        join m in context.MauSacs on sz.MauSacID equals m.ID
                        select new
                        {
                            ID = sz.ID,
                            TenGiay = g.TenGiay,
                            TenThuongHieu = t.TenThuongHieu,
                            TenLoai = l.TenLoai,
                            TenMau = m.TenMau,
                            Size = sz.Size,
                            SoLuongTon = sz.SoLuongTon
                        };

            // Lọc theo Loại giày
            if (cboLoaiGiay.SelectedIndex != -1)
            {
                int loaiID = (int)cboLoaiGiay.ComboBox.SelectedValue!;
                query = query.Where(x => context.Giays.FirstOrDefault(g => g.TenGiay == x.TenGiay)!.LoaiGiayID == loaiID);
            }

            // Lọc theo Thương hiệu
            if (cboThuongHieu.SelectedIndex != -1)
            {
                int thuongHieuID = (int)cboThuongHieu.ComboBox.SelectedValue!;
                query = query.Where(x => context.Giays.FirstOrDefault(g => g.TenGiay == x.TenGiay)!.ThuongHieuID == thuongHieuID);
            }

            // Lọc theo Màu sắc
            if (cboMauSac.SelectedIndex != -1)
            {
                string tenMau = cboMauSac.ComboBox.Text;
                query = query.Where(x => x.TenMau == tenMau);
            }

            // Lọc theo Size
            if (cboSizeGiay.SelectedIndex != -1)
            {
                int size = Convert.ToInt32(cboSizeGiay.ComboBox.SelectedItem);
                query = query.Where(x => x.Size == size);
            }

            // Lọc theo Tên giày (nếu nhập)
            string keyword = txtTuKhoa.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenGiay.ToLower().Contains(keyword));
            }

            dataGridView.DataSource = query.ToList();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmTonKho_Load(sender, e);
            txtTuKhoa.Text = "";
            cboSizeGiay.Text = "";
            cboLoaiGiay.Text = "";
            cboMauSac.Text = "";
            cboThuongHieu.Text = "";
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Mở hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "TonKho_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenThuongHieu", typeof(string)),
                        new DataColumn("TenLoai", typeof(string)),
                        new DataColumn("TenGiay", typeof(string)),
                        new DataColumn("TenMau", typeof(string)),
                        new DataColumn("Size", typeof(int)),
                        new DataColumn("SoLuongTon", typeof(int)),
                    });

                    var query = from sz in context.SizeGiays
                                join g in context.Giays on sz.GiayID equals g.ID
                                join l in context.LoaiGiays on g.LoaiGiayID equals l.ID
                                join t in context.ThuongHieus on g.ThuongHieuID equals t.ID
                                join m in context.MauSacs on sz.MauSacID equals m.ID
                                select new
                                {
                                    ID = sz.ID,
                                    TenThuongHieu = t.TenThuongHieu,
                                    TenLoai = l.TenLoai,
                                    TenGiay = g.TenGiay,
                                    TenMau = m.TenMau,
                                    Size = sz.Size,
                                    SoLuongTon = sz.SoLuongTon
                                };
                    if (query != null)
                    {
                        foreach (var l in query)
                            table.Rows.Add(l.ID, l.TenThuongHieu, l.TenLoai, l.TenGiay, l.TenMau, l.Size, l.SoLuongTon);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Tồn kho");
                        sheet.Columns().AdjustToContents();
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

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
