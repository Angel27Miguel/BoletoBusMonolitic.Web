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
            public DbSet<BoletoBusMonolitic.Web.Data.Models.EmpleadosGuardarModel> EmpleadosGuardarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.EmpleadosEditarModel> EmpleadosEditarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ViajeModel> ViajeModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ReservaModel> ReservaModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ViajeGuardarModel> ViajeGuardarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ViajeEditarModel> ViajeEditarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ReservaDetalleModel> ReservaDetalleModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ReservaGuardarModel> ReservaGuardarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ReservaEditarModel> ReservaEditarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ReservaEliminarModel> ReservaEliminarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.EmpleadosEliminarModel> EmpleadosEliminarModel { get; set; } = default!;
            public DbSet<BoletoBusMonolitic.Web.Data.Models.ReservaDetalleModelGuardar> ReservaDetalleModelGuardar { get; set; } = default!;


        #endregion



    }
}
