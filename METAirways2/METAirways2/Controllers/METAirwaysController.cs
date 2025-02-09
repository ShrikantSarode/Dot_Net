using METAirways2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace METAirways2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class METAirwaysController : ControllerBase
    {
        private  readonly MetairwaysContext context;
        
        public METAirwaysController(MetairwaysContext context) 
        {
            this.context = context;     
        }
        [HttpGet]
        public async Task<ActionResult<List<Flight>>> GetFlights()
        {
            var data = await context.Flights.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlightsById(int id)
        {
            var flight = await context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }
            return flight;
        }

        [HttpPost]
        public async Task<ActionResult<Flight>> CreateWorkshop(Flight fly)
        {
            await context.Flights.AddAsync(fly);
            await context.SaveChangesAsync();
            return Ok(fly);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Flight>> UpdateWorkshop(int id, Flight fly)
        {
            if (id != fly.FlightId)
            {
                return BadRequest();
            }
            context.Entry(fly).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(fly);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Flight>> DeleteWorkshop(int id)
        {
            var work = await context.Flights.FindAsync(id);
            if (work == null)
            {
                return NotFound();
            }
            context.Flights.Remove(work);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
