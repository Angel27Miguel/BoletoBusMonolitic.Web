using BoletoBusMonolitic.Web.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext : DbContext
    {

        public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options) 
        {

        }
       
        #region"DB Sets de Angel Miguel"
            public DbSet<Viaje> Viaje { get; set; }
            public DbSet<Empleados> Empleado { get; set; }
            public DbSet<Reserva> Reserva { get; set; }
            public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
            public DbSet<BoletoBusMonolitic.Web.Data.Models.EmpleadosModel> EmpleadosModel { get; set; } = default!;


        #endregion



    }
}
