using SportsStoreV2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IProductRepository, FakeProductRepository>();


var app = builder.Build();



app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
