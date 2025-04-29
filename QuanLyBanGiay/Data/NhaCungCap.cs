using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class NhaCungCap
    {
        public int ID { get; set; }
        public string TenNhaCungCap { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();
    }
}
