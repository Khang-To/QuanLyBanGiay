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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanGiay.Forms
{
    public partial class frmNhanVien : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        private frmDoiMatKhau? frmDMK = null;
        int id;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTenNhanVien.Enabled = giaTri;
            txtDiaChiNhanVien.Enabled = giaTri;
            txtSDTNhanVien.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        #region Sự kiện
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtMatKhau.Clear();
            txtMatKhau.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            dataGridView.AutoGenerateColumns = false;
            var nv = context.NhanViens.ToList();
            dataGridView.DataSource = nv;
            txtHoVaTenNhanVien.DataBindings.Clear();
            txtHoVaTenNhanVien.DataBindings.Add("Text", nv, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtSDTNhanVien.DataBindings.Clear();
            txtSDTNhanVien.DataBindings.Add("Text", nv, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChiNhanVien.DataBindings.Clear();
            txtDiaChiNhanVien.DataBindings.Add("Text", nv, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", nv, "TenDangNhap", false, DataSourceUpdateMode.Never);
            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", nv, "QuyenHan", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            txtMatKhau.Enabled = true;
            btnDoiMatKhau.Enabled = false;
            id = 0;
            txtHoVaTenNhanVien.Clear();
            txtSDTNhanVien.Clear();
            txtDiaChiNhanVien.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
            txtHoVaTenNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            txtMatKhau.Enabled = false;
            btnDoiMatKhau.Enabled = true;
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
            txtHoVaTenNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTenNhanVien.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                NhanVien nv = context.NhanViens.Find(id)!;
                if (nv != null)
                {
                    context.NhanViens.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTenNhanVien.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txtHoVaTenNhanVien.Text;
                        nv.DienThoai = txtSDTNhanVien.Text;
                        nv.DiaChi = txtDiaChiNhanVien.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text); 
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? "admin" : "user";
                        context.NhanViens.Add(nv);
                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanViens.Find(id)!;
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTenNhanVien.Text;
                        nv.DienThoai = txtSDTNhanVien.Text;
                        nv.DiaChi = txtDiaChiNhanVien.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? "admin" : "user";
                        context.NhanViens.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text); 
                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var nv = context.NhanViens
               .Where(p => p.HoVaTen.Contains(txtTuKhoa.Text) || p.DienThoai!.Contains(txtTuKhoa.Text) || p.DiaChi!.Contains(txtTuKhoa.Text) || p.TenDangNhap!.Contains(txtTuKhoa.Text))
               .ToList();
            dataGridView.DataSource = nv;
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace('/', '-') + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[6]
                         {
                            new DataColumn("ID",typeof(int)),
                            new DataColumn("HoVaTen",typeof(string)),
                            new DataColumn("DienThoai",typeof (string)),
                            new DataColumn("DiaChi",typeof(string)),
                            new DataColumn("TenDangNhap",typeof(string)),
                            new DataColumn("QuyenHan",typeof(string))
                 });
                    var nv = context.NhanViens.ToList();
                    if (nv != null)
                    {
                        foreach (var p in nv)
                        {
                            table.Rows.Add(p.ID, p.HoVaTen, p.DienThoai, p.DiaChi, p.TenDangNhap, p.QuyenHan);
                        }
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "NhanVien");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            txtTuKhoa.Clear();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            if (!string.IsNullOrEmpty(tenDangNhap))
            {
                if (frmDMK == null || frmDMK.IsDisposed)
                {
                    var frm = new frmDoiMatKhau(tenDangNhap, true);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    frmDMK.Activate();
                }
            }
        }
    }
        #endregion       
}
