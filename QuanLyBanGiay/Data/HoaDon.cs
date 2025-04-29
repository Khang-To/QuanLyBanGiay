using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }   //cho phep null

        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiets { get; } = new List<HoaDon_ChiTiet>();
        public virtual KhachHang KhachHang { get; set; } = null!;   //Hoa don phai thuoc ve mot khach hang nao do
        public virtual NhanVien NhanVien { get; set; } = null!; //Co mot hoa don do nhan vien lap
    }
}
