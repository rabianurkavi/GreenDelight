using GreenDelight.Domain.Concrete;
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
    public class GreenDelightDbContext:IdentityDbContext<User, UserRole, Guid>
    {
        public GreenDelightDbContext()
        {
            
        }
        public GreenDelightDbContext(DbContextOptions options):base(options)
        {

        }
        DbSet<Adress> Adresses { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> Items { get; set; }
        DbSet<User> Users { get;set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<Product> Products { get; set; }

        DbSet<ErrorLog> ErrorLogs { get; set; }
        DbSet<Comment> Comments { get; set; }
    }
}
