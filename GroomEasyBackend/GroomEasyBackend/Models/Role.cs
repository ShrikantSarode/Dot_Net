using System.ComponentModel.DataAnnotations;

namespace GroomEasyBackend.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string roleName { get; set; }

        // Navigation property for the one-to-many relationship
        public ICollection<User> Users { get; set; }
    }
}
