using Microsoft.EntityFrameworkCore;
using TeckWorkShopAPIApp.model;

namespace TeckWorkShopAPIApp
{
    public class TechWorkDbContext : DbContext
    {
        public TechWorkDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<TechWorkShop> techWorkShops { get; set; }
    }
}
