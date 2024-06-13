using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class ReservaDetalle : BaseEntity
    {
        //Atributos de la entidad 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
//Angel Miguel de la Rosa