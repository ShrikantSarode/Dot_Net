using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeckWorkShopAPIApp.model;

namespace TeckWorkShopAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechWorkShopController : ControllerBase
    {
        private readonly TechWorkDbContext techWorkDbContext;

        public TechWorkShopController(TechWorkDbContext techWorkDbContext)
        {
            this.techWorkDbContext = techWorkDbContext;
        }

        //add
        [HttpPost]
        [Route("/add")]

        public async Task<IActionResult> addWorkshops(TechWorkShop techWorkShop)
        {
            await techWorkDbContext.techWorkShops.AddAsync(techWorkShop);
            await techWorkDbContext.techWorkShops;

            return Ok(techWorkShop);
        }

        [HttpGet]
        [Route("/get")]
        public async Task<IActionResult> getWorkshops()
        {
            await techWorkDbContext.techWorkShops.FindAsync();
            return Ok();
        }


        [HttpGet]
        [Route("/get/{id}")]
        public async Task<IActionResult> getWorkshopbyId([FromRoute] int id)
        {
           TechWorkShop foundtechWorkShop = await techWorkDbContext.techWorkShops.FindAsync(id);

            if (foundtechWorkShop == null)
            {
                return NotFound();
            }
            return Ok(foundtechWorkShop);
        }

        [Ht]


    }
}
