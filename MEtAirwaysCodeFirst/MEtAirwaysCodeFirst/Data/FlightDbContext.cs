using MEtAirwaysCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace MEtAirwaysCodeFirst.Data
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<MetClass>metclasses { get; set; }
    }
}
