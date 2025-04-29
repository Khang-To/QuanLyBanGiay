using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string QuyenHan { get; set; } = null!; // admin, user

        public virtual ICollection<PhieuNhap> PhieuNhaps { get; } = new List<PhieuNhap>();
        public virtual ICollection<HoaDon> HoaDons { get; } = new List<HoaDon>();
    }
}
