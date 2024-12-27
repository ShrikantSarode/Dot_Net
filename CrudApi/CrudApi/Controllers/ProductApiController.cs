using CrudApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]                         //|
    public class ProductApiController : ControllerBase
    {
        private readonly ProductDbContext dbContext; //after we need to initialise it

        public ProductApiController(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        { 
            var data=await dbContext.Product1.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProductsById(int id)
        {
            var product = await dbContext.Product1.FindAsync(id);//<=Linq used to minimised the task

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> CreateProducts(Product id)
        {
            await dbContext.Product1.AddAsync(id);//<=Linq used to minimised the task
            await dbContext.SaveChangesAsync();//<=Linq used to minimised the task


            return Ok(id);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<Product>>> UpdateProducts(int id, Product pd)
        {


            if (id != pd.ProductId)
            {
                return BadRequest();
            }
            dbContext.Entry(pd).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return Ok(pd);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {

            //var product = await dbContext.Product.FindAsync(id);
            var product = await dbContext.Product1.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            dbContext.Product1.Remove(product);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }


    }
}
