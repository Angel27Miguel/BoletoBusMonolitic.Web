using BoletoBusMonolitic.Web.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

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
        #endregion

    }
}
