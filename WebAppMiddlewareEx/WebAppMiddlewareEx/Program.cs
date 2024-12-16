var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Create middleware
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Om ITUS ");
    await next(context);
});

// Map the "/about" route
app.MapGet("/about", async (context) =>
{
    await context.Response.WriteAsync("About Page");
   
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Shrikant ITUS");
}); //it is a end or program will terminate after Run();



app.Run();
