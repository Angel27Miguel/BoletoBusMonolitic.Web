
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.BL.Services;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.DbObject;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BoletoBusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoBusContext")));


builder.Services.AddScoped<IBus, BusDb>();
builder.Services.AddScoped<IAsiento, AsientoDb>();
builder.Services.AddScoped<IRuta, RutaDb>();
builder.Services.AddScoped<IUsuario, UsuarioDb>();

builder.Services.AddScoped<IBusServices,BusServices >();
builder.Services.AddScoped<IAsientoServices,AsientoServices >();
builder.Services.AddScoped<IRutaServices,RutaServices >();
//builder.Services.AddScoped<IUsuarioServices,UsuarioServices >();

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