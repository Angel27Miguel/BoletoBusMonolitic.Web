using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class BusEditarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdBus { get; set; } 

        public int NumeroPlaca { get; set; } 

        public string Nombre { get; set; } 

        public int CapacidadPiso1 { get; set; } 

        public int CapacidadPiso2 { get; set; } 

        

        public bool Disponible { get; set; } 
    }
}
