using BoletoBusMonolitic.BL.Services;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.BL.Services;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Daos;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BoletoBusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoBusContext"),
    sqlOptions => sqlOptions.EnableRetryOnFailure()));

// Agregar las dependencias del objeto de datos
builder.Services.AddScoped<IDetallePedidoDb, DetallePedidoDb>();
builder.Services.AddScoped<IMenuDb, MenuDb>();
builder.Services.AddScoped<IPedidoDb, PedidoDb>();

// Agregar las dependencias del BL
builder.Services.AddTransient<IDetallePedidoService, DetallePedidoService>();
builder.Services.AddTransient<IPedidoService, PedidoService>();
builder.Services.AddTransient<IMenuService, MenuService>();

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