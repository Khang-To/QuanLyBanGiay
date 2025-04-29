using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class PhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SizeGiayID { get; set; }
        public int SoLuongNhap { get; set; }
        public int DonGiaNhap { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; } = null!;
        public virtual SizeGiay SizeGiay { get; set; } = null!;
    }
}
