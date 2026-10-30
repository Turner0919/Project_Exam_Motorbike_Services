
using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;

namespace MotorbikeServices.DAL.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserUse> UserUses { get; set; }
        public DbSet<UserXe> UserXes { get; set; }

        public DbSet<HangXe> HangXes { get; set; }
        public DbSet<DongXe> DongXes { get; set; }

        public DbSet<QuyChuanBaoDuong> QuyChuanBaoDuongs { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost;Database=MotorbikeServices;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.TenTaiKhoan)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.TenTaiKhoan)
                .IsUnique();

            modelBuilder.Entity<QuyChuanBaoDuong>(entity =>
            {
                entity.HasKey(q => q.Id);

                entity.Property(q => q.LoaiXe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(q => q.TenQuyChuan)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(q => q.ChiPhi)
                    .HasPrecision(18, 2);

                entity.Property(q => q.MoTa)
                    .HasMaxLength(500);
            });
        }
    }
}
