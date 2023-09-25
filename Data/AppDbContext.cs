using Microsoft.EntityFrameworkCore;
using Plat1.Models;

namespace Plat1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options){ 
        
        }
        public DbSet<Order> Clients { get; set; }
        public DbSet<Plat> plats { get; set; }

    }
}
