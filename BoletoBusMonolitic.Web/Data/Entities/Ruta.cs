using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Ruta : BaseEntity
    {
        //atributos
        [Key]
        

        public int IdRuta { get; set; } 
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
