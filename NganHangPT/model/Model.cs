namespace NganHangPT.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Entities")
        {
        }

        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<GD_ChuyenTien> GD_ChuyenTien { get; set; }
        public virtual DbSet<GD_GoiRut> GD_GoiRut { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.MACN)
                .IsFixedLength();

            modelBuilder.Entity<GD_ChuyenTien>()
                .Property(e => e.SOTK_CHUYEN)
                .IsFixedLength();

            modelBuilder.Entity<GD_ChuyenTien>()
                .Property(e => e.SOTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GD_ChuyenTien>()
                .Property(e => e.SOTK_NHAN)
                .IsFixedLength();

            modelBuilder.Entity<GD_ChuyenTien>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<GD_GoiRut>()
                .Property(e => e.SOTK)
                .IsFixedLength();

            modelBuilder.Entity<GD_GoiRut>()
                .Property(e => e.LOAIGD)
                .IsFixedLength();

            modelBuilder.Entity<GD_GoiRut>()
                .Property(e => e.SOTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GD_GoiRut>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SODT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.PHAI)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MACN)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.PHAI)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SODT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MACN)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SOTK)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.CMND)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SODU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MACN)
                .IsFixedLength();
        }
    }
}
