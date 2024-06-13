using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public class DetallePedido : BaseEntity
    {
        [Key]
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }
    }
}
//Ismael Garcia