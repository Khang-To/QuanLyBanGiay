using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    internal class QLBGDbContext : DbContext
    {
        public DbSet<LoaiGiay> LoaiGiays { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<Giay> Giays { get; set; }
        public DbSet<SizeGiay> SizeGiays { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuNhap_ChiTiet> PhieuNhapChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDonChiTiets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBGConnection"].ConnectionString);
        }
    }
}
