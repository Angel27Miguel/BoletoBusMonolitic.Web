
namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ClienteModel
    {

        public int  ClienteID { get; set; }
        public  string? Nombre { get; set; }
        public int Telefono { get; set; }
        public  string? Email { get; set; }
        public object Correo { get; internal set; }
    }
}
