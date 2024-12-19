using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidationEx1.Models;

namespace ValidationEx1.Controllers
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
        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Student(Student student)
        {
            return View();
            //if (ModelState.IsValid)
            //{
            //    return "Name:" + student.Name;
            //}
            //else
            //{
            //    return "Validation Failed";
            //}
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
