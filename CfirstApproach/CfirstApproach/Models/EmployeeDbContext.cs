using Microsoft.EntityFrameworkCore;

namespace CfirstApproach.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employeee> Employes { get; set; }
    }
}
