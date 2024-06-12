namespace BoletoBusMonolitic.Web.Data.Models
{
    public class PedidoAddModel
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdMesa { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }

    }
}
