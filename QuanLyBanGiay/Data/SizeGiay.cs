using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class SizeGiay
    {
        public int ID { get; set; }
        public int GiayID { get; set; }
        public int MauSacID { get; set; }
        public int Size { get; set; }
        public int SoLuongTon { get; set; }

        public virtual Giay Giay { get; set; } = null!;
        public virtual MauSac MauSac { get; set; } = null!;
    }
}
