using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sonia_s_Pizza_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customers> Customers { get; set; }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Orders> Orders { get; set; }
    }
}
