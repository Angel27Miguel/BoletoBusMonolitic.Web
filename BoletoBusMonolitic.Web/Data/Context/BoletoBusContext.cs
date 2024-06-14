using Microsoft.EntityFrameworkCore;

namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext: DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Factura>  Factura { get; set; }
        public DbSet<Mesa> Mesa { get; set; }
        public DbSet<BoletoBusMonolitic.Web.Data.Models.ClienteModel> clienteModels { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.FacturaModel> facturaModels { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.MesaModel> mesaModels { get; set; } = default!;

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }


    }
}
