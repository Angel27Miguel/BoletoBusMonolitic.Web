using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class RutaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdRuta { get; set; }

        public string Origen { get; set; } 

        public string Destino { get; set; } 

        public DateTime? FechaCreacion { get; set; } 
    }
}
