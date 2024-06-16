using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class DetallePedidoAgregarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdPlato { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
