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
        #endregion
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetallePedido>()
                .HasKey(dp => dp.IdDetallePedido);

            
            modelBuilder.Entity<Pedido>()
                .HasKey(p => p.IdPedido);

            
            modelBuilder.Entity<Menu>()
                .HasKey(m => m.IdPlato);

            
            modelBuilder.Entity<DetallePedidoModel>()
                .HasKey(dpm => dpm.IdDetallePedido);

            
            modelBuilder.Entity<DetallePedidoReadModel>()
                .HasKey(dprm => dprm.IdDetallePedido);

            
            modelBuilder.Entity<MenuAddModel>()
                .HasKey(mam => mam.IdPlato);

            
            modelBuilder.Entity<MenuModel>()
                .HasKey(mm => mm.IdPlato);

            
            modelBuilder.Entity<MenuRemoveModel>()
                .HasKey(mrm => mrm.IdPlato);

            
            modelBuilder.Entity<MenuUpdateModel>()
                .HasKey(mum => mum.IdPlato);

            
            modelBuilder.Entity<PedidoAddModel>()
                .HasKey(pam => pam.IdPedido);

            
            modelBuilder.Entity<PedidoModel>()
                .HasKey(pm => pm.IdPedido);

            
            modelBuilder.Entity<PedidoRemoveModel>()
                .HasKey(prm => prm.IdPedido);

            
            modelBuilder.Entity<PedidoUpdateModel>()
                .HasKey(pum => pum.IdPedido);


            base.OnModelCreating(modelBuilder);
        }
        
    }
}