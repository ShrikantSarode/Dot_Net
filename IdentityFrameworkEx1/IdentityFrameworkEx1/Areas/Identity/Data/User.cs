using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkEx1.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        //[Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
