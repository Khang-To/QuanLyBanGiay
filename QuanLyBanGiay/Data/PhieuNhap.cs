using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class PhieuNhap
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayNhap { get; set; }
        public string? GhiChu { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual ICollection<PhieuNhap_ChiTiet> PhieuNhapChiTiets { get; set; } = new List<PhieuNhap_ChiTiet>();
    }
}
