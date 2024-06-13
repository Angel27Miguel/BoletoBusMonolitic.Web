using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ReservaGuardarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public string? Psajero { get; set; }
        public int AsientoReservado { get; set; }
        public double MontoTotal { get; set; }
       
    }
}
//Angel Miguel de la Rosa