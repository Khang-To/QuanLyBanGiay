using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

    [NotMapped]
    public class DanhSachPhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SizeGiayID { get; set; }
        public string TenGiay { get; set; } = null!;    //Bổ sung để lấy tên giày
        public string TenMau { get; set; } = null!;     //Bổ sung để lấy màu
        public int Size { get; set; }       //Bổ sung để lấy size
        public int SoLuongNhap { get; set; }
        public int DonGiaNhap { get; set; }
        public double ThanhTien { get; set; }       //Bổ sung để tính tiền
    }
}