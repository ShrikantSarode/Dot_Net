using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RouterEx4.Models;

namespace RouterEx4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/Shrikant")]
        public IActionResult Shrikant()
        {
            return View();
        }
        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("/About")]
        public IActionResult About()
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
