using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Ruta : BaseEntity
    {
        //atributos
        public int IdRuta { get; set; } 
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
