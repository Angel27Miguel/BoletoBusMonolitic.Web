using BoletoBusMonolitic.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext : DbContext
    {
     
        #region "Constructor"
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options)
        {

        }
        #endregion
        #region "Db Sets"
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<BoletoBusMonolitic.Web.Data.Models.DetallePedidoModel> DetallePedidoModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.MenuModel> MenuModel { get; set; } = default!;
        public DbSet<BoletoBusMonolitic.Web.Data.Models.PedidoModel> PedidoModel { get; set; } = default!;
        #endregion
       
    }
}
