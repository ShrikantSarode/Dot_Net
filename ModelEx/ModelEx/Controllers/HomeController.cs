using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelEx.Models;
using ModelEx.Repository;

namespace ModelEx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly EmployeeRepository _employeeRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _employeeRepository = new EmployeeRepository();
        }

        [Route("")]
        public IActionResult Index()
        {
            //var employees = new List<Employee>()
            //{
            //      new Employee { Id = 101, Name = "Om", Gender = "Male", Level = 2 },
            //    new Employee { Id = 102, Name = "Virat", Gender = "Male", Level = 1 },
            //    new Employee { Id = 103, Name = "Rohit", Gender = "Male", Level = 3 },
            //    new Employee { Id = 104, Name = "Hardik", Gender = "Male", Level = 2 }
            //};

            //ViewData["cdacEmployee"] = employees;

            //var employees = _employeeRepository.GetAllEmployees();
            //ViewData["cdacEmployee"] = employees;
            //return View(employees);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //returns Data Object
        //public List<Employee> getAllEmployees()
        //{
        //    return _employeeRepository.GetAllEmployees();

        //}

        [Route("/All")]
        public IActionResult getAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            ViewData["cdacEmployee"] = employees;
            return View(employees);

        }
        //public Employee getEmployee(int id)
        //{
        //    return _employeeRepository.GetEmployee(id);
        //}

        [Route("/one/{id?}")]
        public IActionResult getEmployee(int id)
        {
            var emp = _employeeRepository.GetEmployee(id);
            ViewData["cdacEmployee"] = emp;
            return View(emp);
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            // Find employee by id from your data source
            var employee = _employeeRepository.GetEmployee(id);
            ViewData["cdacEmployee"] = employee;// view data is used to transfer the data from controller to view
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
