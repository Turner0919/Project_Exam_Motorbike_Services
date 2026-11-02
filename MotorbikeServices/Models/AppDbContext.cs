using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.DAL.Models.Store;

namespace MotorbikeServices.DAL.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<UserUse> UserUses { get; set; }
        public DbSet<DiaChi> DiaChis { get; set; }
        public DbSet<NhanVienUse> NhanVienUses { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<UserXe> UserXes { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<HangXe> HangXes { get; set; }
        public DbSet<DongXe> DongXes { get; set; }

        public DbSet<QuyChuanBaoDuong> QuyChuanBaoDuongs { get; set; }
        public DbSet<QuyChuanXeNguoiDung> QuyChuanXeNguoiDungs { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS;Database=MotorbikeServices;Trusted_Connection=True;TrustServerCertificate=True;");
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
            // Tắt xóa dây chuyền giữa ChiTietHoaDon và SanPham để sửa lỗi Error 1785
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.SanPham)
                .WithMany()
                .HasForeignKey(ct => ct.SanPhamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
