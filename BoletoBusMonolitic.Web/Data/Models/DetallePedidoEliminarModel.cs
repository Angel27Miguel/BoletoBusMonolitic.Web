using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class DetallePedidoEliminarModel
    {
        [Key]
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
