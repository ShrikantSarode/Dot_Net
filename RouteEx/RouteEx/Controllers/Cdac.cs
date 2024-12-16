using Microsoft.AspNetCore.Mvc;

namespace RouteEx.Controllers
{
    public class Cdac : Controller
    {

        [Route("pgdac")]
        public IActionResult PgDac()
        {
            return View();
        }
    }
}
