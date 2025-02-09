////.create db and table
////2.install dependences-tools, design, sql server


////3.appsetting-

////{
////  "Logging": {
////    "LogLevel": {
////        "Default": "Information",
////      "Microsoft.AspNetCore": "Warning"
////    }
////},
////  "ConnectionStrings": {
////    "DBConnection": "Server=CDACLAB-148\\SQLEXPRESS;Database=db_Name;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True"
////  },
////  "AllowedHosts": "*"
////}

////4.to create model and db context-

////Scaffold-DbContext "Server=CDACLAB-148\SQLEXPRESS;database=dbName;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

////5.remove warning from dbContext
////6.Create Empty Web Api Controller
////7. Add this in program.cs

////program.cs

////builder.Services.AddSwaggerGen();

////var provider = builder.Services.BuildServiceProvider();
////var config = provider.GetRequiredService<IConfiguration>();
////builder.Services.AddDbContext<ProductDbContext>
////    (item => item.UseSqlServer(config.GetConnectionString("DBConnection")));

////var app = builder.Build();

////8.web api controller.cs

////create constructor of controller and pass parameter as (dbContext context)

////   public ProductAPIController(ProductDbContext context)
////{
////    this.context = context;
////}
////and press ctrl + .

////9.controller
////using CRUDApi.Models;
////using Microsoft.AspNetCore.Http;
////using Microsoft.AspNetCore.Mvc;
////using Microsoft.EntityFrameworkCore;

////namespace CRUDApi.Controllers
////{
////    [Route("api/[controller]")]
////    [ApiController]
////    public class ProductAPIController : ControllerBase
////    {
////        private readonly ProductDbContext context;

////        public ProductAPIController(ProductDbContext context)
////        {
////            this.context = context;
////        }
//using Microsoft.AspNetCore.Mvc;

//[HttpGet]
//public async Task<ActionResult<List<Workshop>>> GetWorkshop()
//{
//    var data = await context.Workshops.ToListAsync();
//    return Ok(data);
//}

//[HttpGet("{id}")]
//public async Task<ActionResult<Workshop>> GetWorkshopById(int id)
//{
//    var workshop = await context.Workshops.FindAsync(id);
//    if (workshop == null)
//    {
//        return NotFound();
//    }
//    return workshop;
//}

//[HttpPost]
//public async Task<ActionResult<Workshop>> CreateWorkshop(Workshop work)
//{
//    await context.Workshops.AddAsync(work);
//    await context.SaveChangesAsync();
//    return Ok(work);
//}

//[HttpPut("{id}")]
//public async Task<ActionResult<Workshop>> UpdateWorkshop(int id, Workshop work)
//{
//    if (id != work.WorkshopId)
//    {
//        return BadRequest();
//    }
//    context.Entry(work).State = EntityState.Modified;
//    await context.SaveChangesAsync();
//    return Ok(work);
//}


//[HttpDelete("{id}")]
//public async Task<ActionResult<Workshop>> DeleteWorkshop(int id)
//{
//    var work = await context.Workshops.FindAsync(id);
//    if (work == null)
//    {
//        return NotFound();
//    }
//    context.Workshops.Remove(work);
//    await context.SaveChangesAsync();
//    return Ok();
//}
////    }
////}
