namespace BoletoBusMonolitic.Web.Data.Models
{
    public class FacturaModel
    {
        public int IDFactura { get; set; }
        public int IDPedido { get; set; } 
        public int Total { get; set; }
        public DateTime Fecha { get; set; }

    }
}
