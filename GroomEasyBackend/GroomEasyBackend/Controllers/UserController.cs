using GroomEasyBackend.Data;
using GroomEasyBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroomEasyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext userDbContext;

        public UserController(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        //register

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            // Check if the model state is valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Check if the email already exists
            if (await userDbContext.Users.AnyAsync(u => u.Email == user.Email))
            {
                return BadRequest(new { message = "Email already exists! Try another Email ID." });
            }

            // Fetch the Role based on the roleId
            var role = await userDbContext.Role.FindAsync(user.RoleId);

            // If the Role is not found, return an error response
            if (role == null)
            {
                return BadRequest(new { message = "Invalid RoleId! Role not found." });
            }

            // Add the user to the database
            await userDbContext.Users.AddAsync(user);
            await userDbContext.SaveChangesAsync();

            // Return success message as a JSON object
            return Ok(new { message = "Registered Successfully!" });
        }



        //login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Fetch the user based on email and password
            var user = await userDbContext.Users
                .FirstOrDefaultAsync(u => u.Email == loginData.Email && u.Password == loginData.Password);

            if (user == null)
            {
                return Unauthorized("Invalid Email or Password");
            }

            // Fetch the role based on the user's RoleId
            var role = await userDbContext.Role
                .FirstOrDefaultAsync(r => r.Id == user.RoleId);

            if (role == null)
            {
                return Unauthorized("Role not found");
            }

            return Ok(new
            {
                Message = "Login successful",
                UserName = user.Name,
                RoleId = user.RoleId,  // This should be user.RoleId, not user.Id
                RoleName = role.roleName  // Assuming your Role entity has a property "RoleName"
            });
        }


    }
}