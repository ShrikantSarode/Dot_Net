using Microsoft.AspNetCore.Mvc;

namespace RoutingEx3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/MyMethod")]
        public ContentResult ContentResult()
        {
            return Content("Hello .Net Core");
        }

        [Route("/json")]
        public JsonResult JsonResult()
        {
            var name = "Shrikant Sarode";
            return Json(new {name});// new is for object creation
        }
    }
}
