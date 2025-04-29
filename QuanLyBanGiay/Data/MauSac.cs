using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class MauSac
    {
        public int ID { get; set; }
        public string TenMau { get; set; } = null!;

        public virtual ICollection<SizeGiay> SizeGiays { get; set; } = new List<SizeGiay>();
    }
}
