using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;

namespace NutritionApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<FoodProduct> Foods { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nutrition.db");
            optionsBuilder.UseSqlite("Data Source=" + dbPath);
        }

        // configura la relacion entre menu y menuitem
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.Items)
                .WithOne()
                .HasForeignKey(i => i.MenuId);
        }
    }
}