using Microsoft.AspNetCore.Mvc;

namespace LayoutView.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewData["Data1"] = "Shrikant Sarode";
            ViewData["Data2"] = 23;

            string[] arr = ["Sagar", "Shrikant"];
            ViewData["Data3"] = arr;

            ViewData["Data4"] = new List<string>()
            {
                "Student","Employee"
            };

            TempData["Name"] = "Welcome Shrikant !";
            //ViewBag.Message = TempData["Message"];

            return View();


        }
        [Route("/details")]
        public IActionResult Details()
        {
            ViewBag.Title = "Home";

            ViewBag.Data1 = new List<string>()
            {
                "Student","Employee","Trainer"
            };

            return View();
        }
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("/about")]
        public IActionResult About()
        {
            ViewData["Data1"] = "Shrikant";
            ViewData["Data2"] = 23;
           

            return View();
        }

        [Route("/Display")]
        public IActionResult Display()
        {
            return View();
        }



    }
}
