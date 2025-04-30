using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
    public partial class frmThuongHieu : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id;
        public frmThuongHieu()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenThuongHieu.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        #region Sự kiện
        private void frmThuongHieu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<ThuongHieu> th = new List<ThuongHieu>();
            th = context.ThuongHieus.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = th;

            txtTenThuongHieu.DataBindings.Clear();
            txtTenThuongHieu.DataBindings.Add("Text", bindingSource, "TenThuongHieu", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenThuongHieu.Clear();
            txtTenThuongHieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
            txtTenThuongHieu.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thương hiệu " + txtTenThuongHieu.Text + " hay không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                ThuongHieu th = context.ThuongHieus.Find(id)!;
                if (th != null)
                {
                    context.ThuongHieus.Remove(th);
                }
                context.SaveChanges();
                frmThuongHieu_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThuongHieu.Text))
                MessageBox.Show("Vui lòng nhập tên thương hiệu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    ThuongHieu th = new ThuongHieu();
                    th.TenThuongHieu = txtTenThuongHieu.Text;
                    context.ThuongHieus.Add(th);
                    context.SaveChanges();
                }
                else
                {
                    ThuongHieu th = context.ThuongHieus.Find(id)!;
                    if (th != null)
                    {
                        th.TenThuongHieu = txtTenThuongHieu.Text;
                        context.ThuongHieus.Update(th);
                        context.SaveChanges();
                    }
                }
                frmThuongHieu_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmThuongHieu_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var th = context.ThuongHieus
                .Where(r => r.TenThuongHieu.Contains(txtTuKhoa.Text))
                .ToList();
            dataGridView.DataSource = th;
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
                                ThuongHieu th = new ThuongHieu();
                                th.TenThuongHieu = r["TenThuongHieu"].ToString() ?? "N/A";
                                context.ThuongHieus.Add(th);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Nhập dữ liệu thành công " + table.Rows.Count + " dòng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmThuongHieu_Load(sender, e);
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
            saveFileDialog.FileName = "ThuongHieu_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenThuongHieu", typeof(string))
                    });

                    var th = context.ThuongHieus.ToList();
                    if (th != null)
                    {
                        foreach (var p in th)
                            table.Rows.Add(p.ID, p.TenThuongHieu);
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "ThuongHieu");
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
            frmThuongHieu_Load(sender, e);
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
