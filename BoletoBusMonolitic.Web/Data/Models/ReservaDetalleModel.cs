using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ReservaDetalleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReservaDetalle { get; set; }
        public int IdReserva {  get; set; }
        public int IdAsiento { get; set; }
        
        public DateTime FechaCreacion { get; set; }
    }
}
//Angel Miguel de la Rosa