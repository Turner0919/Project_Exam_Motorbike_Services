
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
                entity.HasKey(e => e.Id);

                entity.Property(e => e.TenQuyChuan)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ChiPhi)
                    .HasPrecision(18, 2);

                entity.Property(e => e.MoTa)
                    .HasMaxLength(500);

                entity.HasOne(e => e.DongXe)
                    .WithMany(d => d.QuyChuanBaoDuongs)
                    .HasForeignKey(e => e.DongXeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<QuyChuanBaoDuong>()
                .HasOne(q => q.DongXe)
                .WithMany(d => d.QuyChuanBaoDuongs)
                .HasForeignKey(q => q.DongXeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
