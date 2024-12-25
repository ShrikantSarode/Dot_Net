using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiEx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<string> Employees = new List<string>()
        {
            "Shweta",
            "Sagar",
            "Shrikant",
            "Rani"
        };

        [HttpGet]
        public List<string> GetEmployees()
        {
            return Employees;
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetEmployeesById(int id)
        {
            if (id < 0 || id >= Employees.Count)
            {
                return NotFound();
            }
            return Employees.ElementAt(id);
        }
    }
}
