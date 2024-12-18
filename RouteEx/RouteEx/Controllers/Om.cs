using Microsoft.AspNetCore.Mvc;

namespace RouteEx.Controllers
{
    public class Om : Controller
    {
        [Route("/om")]
        public IActionResult Shanti()
        {
            return View();
        }
    }
}
