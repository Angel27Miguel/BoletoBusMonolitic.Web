namespace BoletoBusMonolitic.Web.Data.Models
{
    public class RutaModel
    {
        public int IdRuta { get; set; }

        public string Origen { get; set; } 

        public string Destino { get; set; } 

        public DateTime? FechaCreacion { get; set; } 
    }
}
