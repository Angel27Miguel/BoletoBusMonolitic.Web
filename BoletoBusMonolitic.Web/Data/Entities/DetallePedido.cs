using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public class DetallePedido : BaseEntity
    {
        public int DetallePedidoId { get; set; }
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }
    }
}
//Ismael Garcia