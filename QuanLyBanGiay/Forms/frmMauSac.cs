using ClosedXML.Excel;
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
    public partial class frmMauSac: Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id;
        public frmMauSac()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtMauSac.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        #region Sự kiện
        private void frmMauSac_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<MauSac> ms = new List<MauSac>();
            ms = context.MauSacs.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ms;

            txtMauSac.DataBindings.Clear();
            txtMauSac.DataBindings.Add("Text", bindingSource, "TenMau", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtMauSac.Clear();
            txtMauSac.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            txtMauSac.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa màu sắc " + txtMauSac.Text + " hay không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                MauSac ms = context.MauSacs.Find(id)!;
                if (ms != null)
                {
                    context.MauSacs.Remove(ms);
                }
                context.SaveChanges();
                frmMauSac_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMauSac.Text))
                MessageBox.Show("Vui lòng nhập tên màu sắc?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    MauSac ms = new MauSac();
                    ms.TenMau = txtMauSac.Text;
                    context.MauSacs.Add(ms);
                    context.SaveChanges();
                }
                else
                {
                    MauSac ms = context.MauSacs.Find(id)!;
                    if (ms != null)
                    {
                        ms.TenMau = txtMauSac.Text;
                        context.MauSacs.Update(ms);
                        context.SaveChanges();
                    }
                }
                frmMauSac_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmMauSac_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var ms = context.MauSacs
                .Where(r => r.TenMau.Contains(txtTuKhoa.Text))
                .ToList();
            dataGridView.DataSource = ms;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ file Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                MauSac ms = new MauSac();
                                ms.TenMau = r["TenMau"].ToString() ?? "N/A";
                                context.MauSacs.Add(ms);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Nhập dữ liệu thành công " + table.Rows.Count + " dòng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmMauSac_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Không có dữ liệu trong file Excel!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra file Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx;*.xlsm";
            saveFileDialog.FileName = "MauSac_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenMau", typeof(string))
                    });

                    var ms = context.MauSacs.ToList();
                    if (ms != null)
                    {
                        foreach (var p in ms)
                            table.Rows.Add(p.ID, p.TenMau);
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "MauSac");
                        sheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Xuất dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmMauSac_Load(sender, e);
            txtTuKhoa.Clear();
        }
        #endregion

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
