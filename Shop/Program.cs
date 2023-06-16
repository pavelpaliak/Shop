using Shop;
using Shop.Interfaces;
using Shop.Mocks;
using System;
using Microsoft.EntityFrameworkCore;
using Shop.Repository;
using Shop.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDBContent>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<IAllCars,CarRepository>();
builder.Services.AddTransient<ICarsCategory,CategoryRepository>();
builder.Services.AddControllersWithViews();


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCart.GetCart(sp));

builder.Services.AddMvc();
builder.Services.AddMemoryCache();
builder.Services.AddSession();


var app = builder.Build();

// Configure the HTTP request pipeline.




if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();


using (var scope = app.Services.CreateScope())
{
	AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
	DBObjects.Initial(content);
}

app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
