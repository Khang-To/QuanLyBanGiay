using ClosedXML.Excel;
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
    public partial class frmHoaDon : Form
    {
        frmHoaDon_ChiTiet? frmHoaDon_ChiTiet = null;
        QLBGDbContext context = new QLBGDbContext();
        int id = 0;
        public frmHoaDon()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        public void BatTatChucNang()
        {
            btnInHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                var hd = context.HoaDons.Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLap,
                    r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiets.Sum(r => (r.SoLuongBan) * r.DonGiaBan),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = hd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BatTatChucNang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmHoaDon_ChiTiet == null || frmHoaDon_ChiTiet.IsDisposed)
            {
                var frmChiTiet = new frmHoaDon_ChiTiet();
                frmChiTiet.MdiParent = this.MdiParent;
                frmChiTiet.Show();

            }
            else
            {
                frmHoaDon_ChiTiet.Activate();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Index >= 0)
            {
                int hoaDonID = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                frmHoaDon_ChiTiet frmChiTiet = new frmHoaDon_ChiTiet(hoaDonID);
                frmChiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa hóa đơn đang chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    var hd = context.HoaDons.Find(id);
                    if (hd != null)
                    {
                        // Xóa chi tiết trước
                        var chiTietList = context.HoaDonChiTiets.Where(ct => ct.HoaDonID == id).ToList();
                        context.HoaDonChiTiets.RemoveRange(chiTietList);

                        // Xóa hóa đơn
                        context.HoaDons.Remove(hd);

                        context.SaveChanges();
                    }

                    frmHoaDon_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
            txtTuKhoa.Clear();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            

            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int hoaDonID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(hoaDonID);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
