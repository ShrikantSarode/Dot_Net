using GroomEasyBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace GroomEasyBackend.Data
{
    public class UserDbContext : DbContext
    {



        public DbSet<User> Users { get; set; }

        public DbSet<Role> Role { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding roles into the database
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, roleName = "Admin" },
                new Role { Id = 2, roleName = "Staff" },
                new Role { Id = 3, roleName = "Customer" }
            );
        }
    }


}

