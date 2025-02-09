//using CRUDApi.Controllers;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//1.create db and table
//2.install dependences-tools, design, sql server


//3.appsetting-

//{
//  "Logging": {
//    "LogLevel": {
//        "Default": "Information",
//      "Microsoft.AspNetCore": "Warning"
//    }
//},
//  "ConnectionStrings": {
//    "DBConnection": "Server=CDACLAB-148\\SQLEXPRESS;Database=db_Name;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True"
//  },
//  "AllowedHosts": "*"
//}

//4.to create model and db context-

//Scaffold-DbContext "Server=CDACLAB-148\SQLEXPRESS;database=dbName;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

//5.remove warning from dbContext
//6.Create Empty Web Api Controller
//7. Add this in program.cs

//program.cs

//builder.Services.AddSwaggerGen();

//var provider = builder.Services.BuildServiceProvider();
//var config = provider.GetRequiredService<IConfiguration>();
//builder.Services.AddDbContext<ProductDbContext>
//    (item => item.UseSqlServer(config.GetConnectionString("DBConnection")));

//var app = builder.Build();

//8.web api controller.cs

//create constructor of controller and pass parameter as (dbContext context)

//   public ProductAPIController(ProductDbContext context)
//{
//    this.context = context;
//}
//and press ctrl + .

//9.controller
//using CRUDApi.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace CRUDApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductAPIController : ControllerBase
//    {
//        private readonly ProductDbContext context;

//        public ProductAPIController(ProductDbContext context)
//        {
//            this.context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<List<Product>>> GetProducts()
//        {
//            var data = await context.Products.ToListAsync();
//            return Ok(data);
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<Product>> GetProductById(int id)
//        {

//            var product = await context.Products.FindAsync(id);


//            if (product == null)
//            {
//                return NotFound();
//            }

//            return product;
//        }

//        [HttpPost]
//        public async Task<ActionResult<Product>> CreateProduct(Product product)
//        {
//            await context.Products.AddAsync(product);
//            await context.SaveChangesAsync();

//            return Ok(product);
//        }

//        [HttpPut("{id}")]
//        public async Task<ActionResult<Product>> UpdateProduct(int id, Product product)
//        {
//            if (id != product.ProductId)
//            {
//                return BadRequest();
//            }

//            context.Entry(product).State = EntityState.Modified;
//            await context.SaveChangesAsync();
//            return Ok(product);
//        }

//        [HttpDelete]
//        public async Task<ActionResult<Product>> DeleteProduct(int id)
//        {
//            var product = await context.Products.FindAsync(id);
//            if (product == null)
//            {
//                return NotFound();
//            }
//            context.Products.Remove(product);
//            await context.SaveChangesAsync();
//            return Ok();
//        }
//    }
//}
