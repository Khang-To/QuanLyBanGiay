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
    public partial class frmLoaiGiay : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id;
        public frmLoaiGiay()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void BatTatChucNang(bool giatri)
        {
            btnLuu.Enabled = giatri;
            btnHuyBo.Enabled = giatri;
            txtTenLoai.Enabled = giatri;
            txtMoTa.Enabled = giatri;

            btnThem.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
            btnSua.Enabled = !giatri;
        }

        private void frmLoaiGiay_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiGiay> lg = new List<LoaiGiay>();
            lg = context.LoaiGiays.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lg;

            txtTenLoai.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();

            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Add("Text", bindingSource, "Mota", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

            var count = dataGridView.Rows.Count;
            if (count == 0)
                txtTenLoai.Text = string.Empty;

            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenLoai.Clear();
            txtMoTa.Clear();
            txtTenLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại sản phẩm " + txtTenLoai.Text + " Không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                LoaiGiay lg = context.LoaiGiays.Find(id)!;
                if (lg != null)
                    context.LoaiGiays.Remove(lg);

                context.SaveChanges();
                frmLoaiGiay_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                if (id == 0) //thêm mới
                {
                    LoaiGiay lg = new LoaiGiay();
                    lg.TenLoai = txtTenLoai.Text;
                    lg.Mota = txtMoTa.Text;
                    context.LoaiGiays.Add(lg);

                    context.SaveChanges();
                }
                else
                {
                    LoaiGiay lg = context.LoaiGiays.Find(id);
                    if (lg != null)
                    {
                        lg.TenLoai = txtTenLoai.Text;
                        lg.Mota = txtMoTa.Text;
                        context.LoaiGiays.Update(lg);

                        context.SaveChanges();
                    }
                }
                frmLoaiGiay_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiGiay_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var lg = context.LoaiGiays
                .Where(r => r.TenLoai.Contains(txtTuKhoa.Text) || r.Mota.Contains(txtTuKhoa.Text))
                .ToList();
            dataGridView.DataSource = lg;
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

                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
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

                        //Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                LoaiGiay lg = new LoaiGiay();
                                lg.TenLoai = row["TenLoai"].ToString() ?? "N/A";
                                lg.Mota = row["Mota"].ToString() ?? "N/A";
                                context.LoaiGiays.Add(lg);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmLoaiGiay_Load(sender, e);
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
            saveFileDialog.FileName = "LoaiGiay_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenLoai", typeof(string)),
                        new DataColumn("Mota", typeof(string)),
                    });

                    var lg = context.LoaiGiays.ToList();
                    if (lg != null)
                    {
                        foreach (var l in lg)
                            table.Rows.Add(l.ID, l.TenLoai, l.Mota);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Loại giày");
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
            frmLoaiGiay_Load(sender, e);
            txtTuKhoa.Text = "";
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
