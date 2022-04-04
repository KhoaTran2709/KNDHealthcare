namespace KND_HEALTHCARE
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BIENBANHUYTHUOC> BIENBANHUYTHUOCs { get; set; }
        public virtual DbSet<CHITIETBIENBAN> CHITIETBIENBANs { get; set; }
        public virtual DbSet<CHITIETPHIEUDATMUA> CHITIETPHIEUDATMUAs { get; set; }
        public virtual DbSet<CHITIETPHIEUMUATHUOC> CHITIETPHIEUMUATHUOCs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHOTHUOC> KHOTHUOCs { get; set; }
        public virtual DbSet<LOAITHUOC> LOAITHUOCs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUDATMUA> PHIEUDATMUAs { get; set; }
        public virtual DbSet<PHIEUMUATHUOC> PHIEUMUATHUOCs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THUOC> THUOCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BIENBANHUYTHUOC>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<BIENBANHUYTHUOC>()
                .HasMany(e => e.CHITIETBIENBANs)
                .WithRequired(e => e.BIENBANHUYTHUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDTKHACHHANG)
                .IsUnicode(false);

            modelBuilder.Entity<KHOTHUOC>()
                .Property(e => e.MAKHO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAITHUOC>()
                .Property(e => e.MAKHO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDTNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDATMUA>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUDATMUA>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDATMUA>()
                .HasMany(e => e.CHITIETPHIEUDATMUAs)
                .WithRequired(e => e.PHIEUDATMUA)
                .HasForeignKey(e => e.SOPHIEUDAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDATMUA>()
                .HasMany(e => e.CHITIETPHIEUDATMUAs1)
                .WithRequired(e => e.PHIEUDATMUA1)
                .HasForeignKey(e => e.SOPHIEUDAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUMUATHUOC>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUMUATHUOC>()
                .Property(e => e.SDTKHACHHANG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUMUATHUOC>()
                .HasMany(e => e.CHITIETPHIEUMUATHUOCs)
                .WithRequired(e => e.PHIEUMUATHUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.HINHTHUOC)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CHITIETBIENBANs)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CHITIETPHIEUDATMUAs)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CHITIETPHIEUMUATHUOCs)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);
        }
    }
}
