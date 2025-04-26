using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class ThuongHieu
    {
        public int ID { get; set; }
        public string TenThuongHieu { get; set; } = null!;

        public virtual ICollection<Giay> Giays { get; set; } = new List<Giay>();
    }
}
