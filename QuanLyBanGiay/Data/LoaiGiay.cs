using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class LoaiGiay
    {
        public int ID { get; set; }
        public string TenLoai { get; set; } = null!;

        public virtual ICollection<Giay> Giays { get; set; } = new List<Giay>();
    }
}
