using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public class Pedido : BaseEntity
    {
        [Key]
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdMesa { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
