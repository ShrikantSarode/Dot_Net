using MEtAirwaysCodeFirst.Data;
using MEtAirwaysCodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MEtAirwaysCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly FlightDbContext context;
        public FlightsController(FlightDbContext context) {
                this.context = context;
        }
        [HttpPost]
        [Route("/add")]
        public async Task<ActionResult> addFlight(MetClass metClass)
        {
            await context.metclasses.AddAsync(metClass);
            await context.SaveChangesAsync();   
            return Ok(metClass);    
        }
        [HttpGet]
        [Route("/get")]
        public async Task<ActionResult> getFlight()
        {

            return Ok(await context.metclasses.ToListAsync());
        }

        [HttpPut]
        [Route("/put")]
        public async Task<ActionResult> UpdateFlight(int id,MetClass updatemetClass)
        {
          MetClass foundMetClass = await context.metclasses.FindAsync(id);
            if (foundMetClass == null)
            {
                foundMetClass.FlightName = updatemetClass.FlightName;
                foundMetClass.NoOfSeatsBooked = updatemetClass.NoOfSeatsBooked;
                await context.SaveChangesAsync();   
                return Ok(foundMetClass);    
            
            }

            return NotFound();  
        }
        [HttpDelete]
        [Route("/delete")]
        public async Task<ActionResult> DeleteFlight(int id)
        {
            MetClass foundMetClass = await context.metclasses.FindAsync(id);
            if(foundMetClass != null)
            {
                context.Remove(foundMetClass);
               await  context.SaveChangesAsync();
                return Ok("Deleted");       
            }
            return NotFound();
        }
    }
}
