using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RouteEx.Models;

namespace RouteEx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Shri")]
        public IActionResult Shri()
        {
            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/Privacy")]
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
