using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Correct namespace for Identity in .NET Core
using Microsoft.EntityFrameworkCore;
using ProBackend.Models;

namespace ProBackend.Data
{
    public class ApplicationDbContext : IdentityDbContext<Users> // Use IdentityDbContext from AspNetCore
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
