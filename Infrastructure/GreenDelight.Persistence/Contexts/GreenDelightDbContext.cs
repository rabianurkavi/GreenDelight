using GreenDelight.Domain.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Contexts
{
    public partial class GreenDelightDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public GreenDelightDbContext()
        {

        }
        public GreenDelightDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=RABIA\\SQLEXPRESS;Database=GreenDelightDB;Trusted_Connection=True;TrustServerCertificate=true");
            }
        }
        DbSet<Adress> Adresses { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Neighborhood> Neighborhoods { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<ErrorLog> ErrorLogs { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<About> Abouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Base metodu çağırarak Identity yapılandırmalarını koruyun

            // Identity tablolarının anahtar türünü belirtin
            modelBuilder.Entity<IdentityUser<Guid>>().HasKey(u => u.Id);
            modelBuilder.Entity<IdentityRole<Guid>>().HasKey(r => r.Id);
            modelBuilder.Entity<IdentityUserLogin<Guid>>().HasKey(ul => ul.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<IdentityUserClaim<Guid>>().HasKey(uc => uc.Id);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().HasKey(rc => rc.Id);

        }

    }
}
