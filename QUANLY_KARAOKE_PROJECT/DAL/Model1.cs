using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class KaraokeContextDB : DbContext
    {
        public KaraokeContextDB()
            : base("name=KaraokeContextDB")
        {
        }

        public virtual DbSet<DAT_PHONG> DAT_PHONG { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<HOA_DON_SAN_PHAM> HOA_DON_SAN_PHAM { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<LOAI_PHONG> LOAI_PHONG { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<PLAYLIST> PLAYLISTs { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONG_TIN_QUAN> THONG_TIN_QUAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAT_PHONG>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.DAT_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.IDHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .HasMany(e => e.HOA_DON_SAN_PHAM)
                .WithRequired(e => e.HOA_DON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOA_DON_SAN_PHAM>()
                .Property(e => e.IDHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.DAT_PHONG)
                .WithRequired(e => e.KHACH_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.KHACH_HANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAI_PHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAI_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.DAT_PHONG)
                .WithRequired(e => e.PHONG)
                .HasForeignKey(e => e.IDPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.DAT_PHONG1)
                .WithRequired(e => e.PHONG1)
                .HasForeignKey(e => e.IDPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAN_PHAM>()
                .HasMany(e => e.HOA_DON_SAN_PHAM)
                .WithRequired(e => e.SAN_PHAM)
                .WillCascadeOnDelete(false);
        }
    }
}
