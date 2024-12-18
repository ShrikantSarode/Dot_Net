using Microsoft.AspNetCore.Mvc;

namespace RoutingEx2.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }

        //public ActionResult Home()
        //{
        //    return View();
        //}

        //public PartialViewResult About()
        //{
        //    return View();
        //}

        //public JsonResult Contact()
        //{
        //    return View();
        //}
    }
}
