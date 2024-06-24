using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class AsientoEditarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdAsiento { get; set; } 

        public int IdBus { get; set; } 

        public int NumeroPiso { get; set; } 

        public int NumeroAsiento { get; set; } 

        public DateTime FechaCreacion { get; set; } 
    }
}
