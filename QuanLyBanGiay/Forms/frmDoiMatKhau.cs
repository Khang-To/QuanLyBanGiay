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
using static QuanLyBanGiay.Forms.frmMain;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanGiay.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        bool doiChoNguoiKhac = false;
        string tenDangNhapGoc = "";

        public frmDoiMatKhau(string tenDangNhap, bool laDoiChoNguoiKhac = false)
        {
            InitializeComponent();
            tenDangNhapGoc = tenDangNhap;
            this.doiChoNguoiKhac = laDoiChoNguoiKhac;

            txtTenDangNhap.Text = tenDangNhap;
            txtTenDangNhap.ReadOnly = true;

            if (doiChoNguoiKhac)
            {
                txtMatKhauCu.Enabled = false;
                txtMatKhauCu.PlaceholderText = "(Không cần)";
            }
        }


        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tenDangNhapGoc;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nv = context.NhanViens.FirstOrDefault(r => r.TenDangNhap == tenDangNhap);
            if (nv == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!doiChoNguoiKhac)
            {
                if (string.IsNullOrWhiteSpace(matKhauCu))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!BC.Verify(matKhauCu, nv.MatKhau))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            nv.MatKhau = BC.HashPassword(matKhauMoi);
            context.SaveChanges();

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
