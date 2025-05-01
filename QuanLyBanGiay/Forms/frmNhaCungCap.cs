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
    public partial class frmNhaCungCap : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id;
        public frmNhaCungCap()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        #region Sự kiện
        private void BatTatChucNang(bool giatri)
        {
            btnLuu.Enabled = giatri;
            btnHuyBo.Enabled = giatri;
            txtHoVaTen.Enabled = giatri;
            txtDienThoai.Enabled = giatri;
            txtDiaChi.Enabled = giatri;

            btnThem.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
            btnSua.Enabled = !giatri;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            var ncc = context.NhaCungCaps.ToList();
            dataGridView.DataSource = ncc;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", ncc, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", ncc, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", ncc, "DiaChi", false, DataSourceUpdateMode.Never);

            var count = dataGridView.Rows.Count;
            if (count == 0)
            {
                txtHoVaTen.Text = string.Empty;
                txtDienThoai.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
            }

            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = 0;
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhà cung cấp " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                NhaCungCap ncc = context.NhaCungCaps.Find(id)!;
                if (ncc != null)
                {
                    context.NhaCungCaps.Remove(ncc);
                }
                context.SaveChanges();
                frmNhaCungCap_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhà cung cấp?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)    //Thêm mới
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.TenNhaCungCap = txtHoVaTen.Text;
                    ncc.DienThoai = txtDienThoai.Text;
                    ncc.DiaChi = txtDiaChi.Text;
                    context.NhaCungCaps.Add(ncc);
                    context.SaveChanges();
                }
                else    //Sửa
                {
                    NhaCungCap ncc = context.NhaCungCaps.Find(id)!;
                    if (ncc != null)
                    {
                        ncc.TenNhaCungCap = txtHoVaTen.Text;
                        ncc.DienThoai = txtDienThoai.Text;
                        ncc.DiaChi = txtDiaChi.Text;
                        context.NhaCungCaps.Update(ncc);
                        context.SaveChanges();
                    }
                }
                frmNhaCungCap_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var ncc = context.NhaCungCaps
                .Where(r => r.TenNhaCungCap.Contains(txtTuKhoa.Text) || r.DiaChi!.Contains(txtTuKhoa.Text) || r.DienThoai!.Contains(txtTuKhoa.Text))
                .ToList();
            dataGridView.DataSource = ncc;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //Mở hộp thoại mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu vào tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = wb.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        //
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            //
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

                        //
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                NhaCungCap ncc = new NhaCungCap();
                                ncc.TenNhaCungCap = row["TenNhaCungCap"].ToString() ?? "N/A";
                                ncc.DiaChi = row["DiaChi"].ToString() ?? "N/A";
                                ncc.DienThoai = row["DienThoai"].ToString() ?? "N/A";
                                context.NhaCungCaps.Add(ncc);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhaCungCap_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Mở hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhaCungCap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenNhaCungCap", typeof(string)),
                        new DataColumn("DienThoai", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                    });

                    var ncc = context.NhaCungCaps.ToList();
                    if (ncc != null)
                    {
                        foreach (var k in ncc)
                            table.Rows.Add(k.ID, k.TenNhaCungCap, k.DienThoai, k.DiaChi);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Nhà cung cấp");
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
            txtTuKhoa.Text = "";
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
        #endregion
    }
}
