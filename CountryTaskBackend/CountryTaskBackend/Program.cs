using CountryTaskBackend.Models.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(cfg =>
{
    cfg.UseInMemoryDatabase("CountryDb");
});
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(name: "default", pattern: "{controller=countries}/{action=index}/{id?}");

app.Seed();

app.Run();
