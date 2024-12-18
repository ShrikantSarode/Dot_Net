var builder = WebApplication.CreateBuilder(args);

//app.MapGet("/", () => "Hello World!");
builder.Services.AddControllersWithViews();

var app = builder.Build();
 

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.MapControllers();

app.Run();
