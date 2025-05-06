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
    public partial class frmHoaDon_ChiTiet : Form
    {
        frmKhachHang? frmKhachHang = null!;
        QLBGDbContext context = new QLBGDbContext();
        int id = 0;
        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            id = maHoaDon;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanViens.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHangs.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LayMauSacVaoComboBox()
        {
            cboMauSac.DataSource = context.MauSacs.ToList();
            cboMauSac.ValueMember = "ID";
            cboMauSac.DisplayMember = "TenMau";
        }

        public void LaySizeVaoComboBox()
        {
            cboSize.DataSource = context.SizeGiays.ToList();
            cboSize.ValueMember = "ID";
            cboSize.DisplayMember = "Size";
        }

        public void LayLoaiGiayVaoComboBox()
        {
            cboLoaiGiay.DataSource = context.LoaiGiays.ToList();
            cboLoaiGiay.ValueMember = "ID";
            cboLoaiGiay.DisplayMember = "TenLoai";
        }

        public void LayGiayVaoComboBox()
        {
            
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numDonGiaBan.Value = 0;
                numSoLuongBan.Value = 1;
            }
            btnLuu.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayGiayVaoComboBox();
            LayKhachHangVaoComboBox();
            LayNhanVienVaoComboBox();
            LayLoaiGiayVaoComboBox();
            LayMauSacVaoComboBox();
            LaySizeVaoComboBox();
           
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
           
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }


        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            if (frmKhachHang == null || frmKhachHang.IsDisposed)
            {
                var frmKhachHang = new frmKhachHang();
                frmKhachHang.MdiParent = this.MdiParent;
                frmKhachHang.Show();

            }
            else
            {
                frmKhachHang.Activate();
            }
        }
    }
}