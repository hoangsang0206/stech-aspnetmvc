﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STech.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbEntities : DbContext
    {
        public DbEntities()
            : base("name=DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChiTietKho> ChiTietKhoes { get; set; }
        public virtual DbSet<ChiTietPN> ChiTietPNs { get; set; }
        public virtual DbSet<ChiTietPXK> ChiTietPXKs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<HinhAnhSP> HinhAnhSPs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<Megamenu> Megamenus { get; set; }
        public virtual DbSet<MegamenuItem> MegamenuItems { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
        public virtual DbSet<PhieuDoiTra> PhieuDoiTras { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuatKho> PhieuXuatKhoes { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SidebarMenu> SidebarMenus { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<TheThanhVien> TheThanhViens { get; set; }
        public virtual DbSet<ThongSoKyThuat> ThongSoKyThuats { get; set; }
        public virtual DbSet<TichDiem> TichDiems { get; set; }
    }
}
