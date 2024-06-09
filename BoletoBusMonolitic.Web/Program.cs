using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.BL.Services;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Date.Daos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BoletoBusContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoBusContext")));


// Agregar las dependencias del objeto de datos //
builder.Services.AddScoped<IViajeDb, ViajeDb>();


// Agregar las dependencias del BL //
builder.Services.AddTransient<IviajeServices, ViajeService>();


builder.Services.AddControllersWithViews();

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
