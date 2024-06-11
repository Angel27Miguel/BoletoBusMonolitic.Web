namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext : DbContext
    {
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

        #region "Db Sets de angel naut"

        public DbSet<Bus> Bus { get; set; }
        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


    }
}
