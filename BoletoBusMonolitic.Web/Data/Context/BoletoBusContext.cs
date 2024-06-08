using BoletoBusMonolitic.Web.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        public BoletoBusContext()
        {
        }
        #region "Constructor"
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options)
        {
            
        }
#
        #endregion
        #region "Db Sets"
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<Menu> Menu { get; set; }
        #endregion
    }
}
