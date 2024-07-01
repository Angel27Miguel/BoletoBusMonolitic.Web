using BoletoBusMonolitic.Web.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options) { }


        #region "Db Sets de angel naut"

        public DbSet<Bus> Bus { get; set; }
        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<BoletoBusMonolitic.Web.Data.Models.AsientoModel> AsientoModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.BusModel> BusModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.RutaModel> RutaModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.UsuarioModel> UsuarioModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.AsientoGuardarModel> AsientoGuardarModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.BusGuardarModel> BusGuardarModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.BusEditarModel> BusEditarModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.UsuarioEditarModel> UsuarioEditarModel { get; set; } = default!;
        #endregion

    }
}
