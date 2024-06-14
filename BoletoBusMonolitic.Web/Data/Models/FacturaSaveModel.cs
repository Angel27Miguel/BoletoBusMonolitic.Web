namespace BoletoBusMonolitic.Web.Data.Models
{
    public class FacturaSaveModel
    {
        public int IDFactura { get; set; }
        public int IDPedido { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Create { get; set; }

    }
}
