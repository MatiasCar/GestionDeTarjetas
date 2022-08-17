
using GestionDeTarjetas.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var server = builder.Configuration.GetConnectionString("Server");
var database = builder.Configuration.GetConnectionString("Database");
var user = builder.Configuration.GetConnectionString("User");
var password = builder.Configuration.GetConnectionString("Password");
var inicialization = new Inicialization(server, database, user, password);

builder.Services.AddDbContext<ContextDB>(options => options.UseSqlServer(inicialization.GetConnectionString()));

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
