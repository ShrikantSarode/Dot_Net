using GroomEasyBackend.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [StringLength(200, ErrorMessage = "Email can't be longer than 200 characters.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
    public string Password { get; set; }

    [Phone(ErrorMessage = "Invalid mobile number format.")]
    public string Mobile { get; set; }

    // Only RoleId will be passed in the request body, not the entire Role object.
    [Required]
    public int RoleId { get; set; }

    // Navigation property for the one-to-many relationship (Role is related to the user)
    //[ForeignKey("RoleId")]
    //public Role Role { get; set; }
}
