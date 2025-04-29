using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class Giay
    {
        public int ID { get; set; }
        public string TenGiay { get; set; } = null!;
        public int ThuongHieuID { get; set; }
        public int LoaiGiayID { get; set; }
        public int GiaBan { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; } = null!;
        public virtual LoaiGiay LoaiGiay { get; set; } = null!;
        public virtual ICollection<SizeGiay> SizeGiays { get; set; } = new List<SizeGiay>();
    }
}
