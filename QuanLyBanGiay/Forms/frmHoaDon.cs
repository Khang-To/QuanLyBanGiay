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
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                }
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
                if (MessageBox.Show("Xác nhận xóa hóa đơn đang chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    HoaDon hd = context.HoaDons.Find(id)!;
                    if (hd != null)
                    {
                        // Xóa chi tiết hóa đơn
                        HoaDon_ChiTiet ct = context.HoaDonChiTiets.Where(r => r.HoaDonID == id).SingleOrDefault()!;
                        context.HoaDonChiTiets.Remove(ct);
                        // Xóa hóa đơn
                        context.HoaDons.Remove(hd);
                        context.SaveChanges();
                    }
                    frmHoaDon_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (e.ColumnIndex == 5)
                btnSua_Click(sender, e);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
