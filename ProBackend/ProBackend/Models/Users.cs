


using Microsoft.AspNet.Identity.EntityFramework;

namespace ProBackend.Models
{
    public class Users : IdentityUser
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
