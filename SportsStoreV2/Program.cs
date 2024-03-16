using Microsoft.EntityFrameworkCore;
using SportsStoreV2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IProductRepository, EFProductRepository>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(connectionString).Options;
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(connectionString));


var app = builder.Build();


app.MapControllerRoute(
		name: "pagination",
		pattern: "Products/Page{productPage}",
		defaults: new { Controller = "Product", Action = "List" });
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Product}/{action=List}/{id?}");


app.Run();
