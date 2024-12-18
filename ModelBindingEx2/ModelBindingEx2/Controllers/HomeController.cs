using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelBindingEx2.Models;

namespace ModelBindingEx2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(User model)
        {
            return "Name: " + model.Name
                + "Gender: " + model.Gender
                + "Age: " + model.Age
                + "Designation: " + model.Designation
                + "Salary: " + model.Salary
                +"Married: "+model.Married
                +"Description: "+model.Description;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
