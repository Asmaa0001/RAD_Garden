using Microsoft.EntityFrameworkCore;
using RAD_Garden.Models; // Ensure this matches your namespace
using Microsoft.Extensions.DependencyInjection;
using RAD_Garden.Data;
using Microsoft.AspNetCore.Identity;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RAD_GardenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RAD_GardenContext") ?? throw new InvalidOperationException("Connection string 'RAD_GardenContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the database context
builder.Services.AddDbContext<FlowerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


