using ClosedXML.Excel;
using QuanLyBanGiay.Data;
using SlugGenerator;
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
    public partial class frmGiay : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        int id; //tạo biến id để thêm sửa
        string imageName = "no-image.jpg"; // Hình ảnh mặc định
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");   //thay thế từ thư mục bin vào thư mục Images

        public frmGiay()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void BatTatChucNang(bool giaTri)
        {
            //Làm mờ nút lưu hủy
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            //làm sáng nút thêm sửa xóa
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;

            //làm mờ các control
            cboLoaiGiay.Enabled = giaTri;
            cboThuongHieu.Enabled = giaTri;
            txtTenGiay.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            numGiaBan.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
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

        private void frmGiay_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            //Đổ dữ liệu lên các ComboBox
            LayLoaiGiayVaoComboBox();
            LayThuongHieuVaoComboBox();

            //Đổ dữ liệu lên datagridview
            var g = context.Giays.Select(r => new
            {
                r.ID,
                r.LoaiGiayID,
                r.LoaiGiay.TenLoai,
                r.ThuongHieuID,
                r.ThuongHieu.TenThuongHieu,
                r.TenGiay,
                r.GiaBan,
                r.HinhAnh,
                r.MoTa
            }).ToList();
            dataGridView.DataSource = g;

            cboLoaiGiay.DataBindings.Clear();
            cboLoaiGiay.DataBindings.Add("SelectedValue", g, "LoaiGiayID", false, DataSourceUpdateMode.Never);

            // cboThuongHieu
            cboThuongHieu.DataBindings.Clear();
            cboThuongHieu.DataBindings.Add("SelectedValue", g, "ThuongHieuID", false, DataSourceUpdateMode.Never);

            txtTenGiay.DataBindings.Clear();
            txtTenGiay.DataBindings.Add("Text", g, "TenGiay", false, DataSourceUpdateMode.Never);

            //  txtMoTa
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", g, "MoTa", false, DataSourceUpdateMode.Never);

            //  numGiaBan
            numGiaBan.DataBindings.Clear();
            numGiaBan.DataBindings.Add("Value", g, "GiaBan", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            //biding hinhAnh tu duong dan thanh hinh
            Binding hinhAnh = new Binding("ImageLocation", g, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            var count = dataGridView.Rows.Count;
            if (count == 0)
            {
                txtTenGiay.Text = string.Empty;
                txtMoTa.Text = string.Empty;
                cboLoaiGiay.Text = string.Empty;
                cboThuongHieu.Text = string.Empty;
                numGiaBan.Value = 0;
                picHinhAnh.Image = null;
            }

        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                //Su ket hop giua thu muc chua file va gia tri trong cai o hinh anh
                string imagePath = Path.Combine(imageFolder, e.Value?.ToString() ?? imageName); //đúng thì trả về hình ảnh sai trả về hình "no image"
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = 0;
            cboLoaiGiay.Text = "";
            cboThuongHieu.Text = "";
            txtTenGiay.Clear();
            txtMoTa.Clear();
            numGiaBan.Value = 0;
            picHinhAnh.Image = null;
            cboThuongHieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                cboThuongHieu.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa mẫu giày " + txtTenGiay.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    Giay g = context.Giays.Find(id)!;
                    if (g != null)
                    {
                        // Xóa hình ảnh (nếu có)
                        if (!string.IsNullOrEmpty(g.HinhAnh))
                        {
                            string imagePath = Path.Combine(imageFolder, g.HinhAnh);
                            if (File.Exists(imagePath))
                            {
                                System.GC.Collect();
                                System.GC.WaitForPendingFinalizers();
                                File.Delete(imagePath);
                            }
                        }
                        context.Giays.Remove(g);
                        context.SaveChanges();
                    }
                    frmGiay_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiGiay.Text))
                MessageBox.Show("Vui lòng chọn loại giày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboThuongHieu.Text))
                MessageBox.Show("Vui lòng chọn thương hiệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenGiay.Text))
                MessageBox.Show("Vui lòng nhập tên giày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numGiaBan.Value <= 0)
                MessageBox.Show("Giá bán giày phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    Giay g = new Giay();
                    g.ThuongHieuID = Convert.ToInt32(cboThuongHieu.SelectedValue?.ToString());
                    g.LoaiGiayID = Convert.ToInt32(cboLoaiGiay.SelectedValue?.ToString());
                    g.TenGiay = txtTenGiay.Text;
                    g.GiaBan = Convert.ToInt32(numGiaBan.Value);
                    g.HinhAnh = imageName;
                    g.MoTa = txtMoTa.Text;
                    context.Giays.Add(g);
                    context.SaveChanges();
                }
                else
                {
                    Giay g = context.Giays.Find(id)!;
                    if (g != null)
                    {
                        g.ThuongHieuID = Convert.ToInt32(cboThuongHieu.SelectedValue?.ToString());
                        g.LoaiGiayID = Convert.ToInt32(cboLoaiGiay.SelectedValue?.ToString());
                        g.TenGiay = txtTenGiay.Text;
                        g.GiaBan = Convert.ToInt32(numGiaBan.Value);
                        g.HinhAnh = imageName;
                        g.MoTa = txtMoTa.Text;
                        context.Giays.Update(g);
                        context.SaveChanges();
                    }
                }
                frmGiay_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmGiay_Load(sender, e);
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.webp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                // Lưu tên file hình vào biến toàn cục
                imageName = fileName.GenerateSlug() + ext;
                // Sao chép file hình vào thư mục Images
                string fileSavePath = Path.Combine(imageFolder, imageName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                // Hiện hình ảnh đã chọn lên PictureBox
                picHinhAnh.Image = Image.FromFile(fileSavePath);
            }
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
                                Giay g = new Giay();
                                g.ThuongHieuID = Convert.ToInt32(row["ThuongHieuID"].ToString() ?? "N/A");
                                g.LoaiGiayID = Convert.ToInt32(row["LoaiGiayID"].ToString() ?? "N/A");
                                g.TenGiay = row["TenGiay"].ToString() ?? "N/A";
                                g.GiaBan = Convert.ToInt32(row["DonGia"].ToString() ?? "N/A");
                                g.HinhAnh = row["HinhAnh"].ToString() ?? "N/A";
                                g.MoTa = row["MoTa"].ToString() ?? "N/A";
                                context.Giays.Add(g);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmGiay_Load(sender, e);
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
            saveFileDialog.FileName = "Giay_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("ThuongHieuID", typeof(int)),
                        new DataColumn("TenThuongHieu", typeof(string)),
                        new DataColumn("LoaiGiayID", typeof(int)),
                        new DataColumn("TenLoai", typeof(string)),
                        new DataColumn("TenGiay", typeof(string)),
                        new DataColumn("GiaBan", typeof(int)),
                        new DataColumn("HinhAnh", typeof(string)),
                        new DataColumn("MoTa", typeof(string)),
                    });

                    var g = context.Giays.ToList();

                    if (g != null)
                    {
                        foreach (var s in g)
                            table.Rows.Add(s.ID, s.ThuongHieuID, s.ThuongHieu.TenThuongHieu, s.LoaiGiayID, s.LoaiGiay.TenLoai, s.TenGiay, s.GiaBan, s.HinhAnh, s.MoTa);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Giày");
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
            frmGiay_Load(sender, e);
            txtTuKhoa.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var sp = context.Giays
                .Where(r => r.TenGiay.Contains(txtTuKhoa.Text) || r.ThuongHieu.TenThuongHieu.Contains(txtTuKhoa.Text) || r.LoaiGiay.TenLoai.Contains(txtTuKhoa.Text))
                .Select(r => new
                {
                    r.ID,
                    r.LoaiGiayID,
                    r.LoaiGiay.TenLoai,
                    r.ThuongHieuID,
                    r.ThuongHieu.TenThuongHieu,
                    r.TenGiay,
                    r.GiaBan,
                    r.HinhAnh,
                    r.MoTa
                }).ToList();
            dataGridView.DataSource = sp;
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