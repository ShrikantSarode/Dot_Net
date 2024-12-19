using System.ComponentModel.DataAnnotations;

namespace ValidationEx1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(15, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        //[EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]

        //[StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one digit, and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Age")]
        [Range(20, 25, ErrorMessage = "Please Enter Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please Enter Phone")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Invalid phone number format.")]
        public int Phone { get; set; }



        [Required(ErrorMessage = "Please Enter URL")]
        [RegularExpression(@"^https?://([\w-]+\.)+[\w-]+(/[\w-]*)?$", ErrorMessage = "Invalid URL format. Must start with http:// or https://.")]
        public string Url { get; set; }





    }
}
