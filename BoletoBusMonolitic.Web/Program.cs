

using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.BL.Services;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.DbObject;
using BoletoBusMonolitic.Web.Data.Entities;

using BoletoBusMonolitic.Web.Date.Daos;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BoletoBusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoBusContext")));

//Agregar las dependencias del objeto de datos


//Agregar las dependencias del BL



// Agregar servicios de autorización
builder.Services.AddAuthorization();

builder.Services.AddControllersWithViews();

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
