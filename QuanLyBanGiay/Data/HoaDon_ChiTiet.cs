using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SizeGiayID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SizeGiay SizeGiay { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        public int GiayID { get; set; }
        public string TenGiay { get; set; } = "";
        public string Loai { get; set; } = "";
        public string MauSac { get; set; } = "";
        public int Size { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }

        public double ThanhTien => SoLuongBan * DonGiaBan;
    }

}