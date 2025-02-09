using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            await techWorkDbContext.SaveChangesAsync();

            return Ok(techWorkShop);
        }

        [HttpGet]
        [Route("/get")]
        public async Task<IActionResult> getWorkshops()
        {
           
            return Ok(await techWorkDbContext.techWorkShops.ToListAsync());
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

        [HttpDelete]
        [Route("/delete/{id}")]
        public async Task<IActionResult> deleteWorkshopbyId([FromRoute] int id)
        {
            TechWorkShop foundtechWorkShop = await techWorkDbContext.techWorkShops.FindAsync(id);

            if (foundtechWorkShop != null)
            {
                techWorkDbContext.techWorkShops.Remove(foundtechWorkShop);
                await techWorkDbContext.SaveChangesAsync();
                return Ok(id+" TechWorkshop deleted");
            }
            return NotFound();
        }


        [HttpPut]
        [Route("/update/{id}")]
        public async Task<IActionResult> updateById([FromRoute] int id, TechWorkShop tech)
        {
            TechWorkShop foundtechWorkShop = await techWorkDbContext.techWorkShops.FindAsync(id);

            if (foundtechWorkShop != null)
            {
                foundtechWorkShop.price=tech.price;
               foundtechWorkShop.date=tech.date;
                 foundtechWorkShop.workShopName=tech.workShopName;
                await techWorkDbContext.SaveChangesAsync();

                return Ok(id + " TechWorkshop updated");
            }
            return NotFound();

        }

        


    }
}
