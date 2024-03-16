using SportsStoreV2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IProductRepository, FakeProductRepository>();


var app = builder.Build();



app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Product}/{action=List}/{id?}");

app.Run();
