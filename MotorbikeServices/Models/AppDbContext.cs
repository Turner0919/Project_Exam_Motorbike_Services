    using Microsoft.EntityFrameworkCore;
    using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Text;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MotorbikeServices;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Đảm bảo TenTaiKhoan là duy nhất (Unique)
            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.TenTaiKhoan)
                .IsUnique();

                modelBuilder.Entity<User>()
                    .HasIndex(u => u.TenTaiKhoan)
                    .IsUnique();
            }
        }
    }
