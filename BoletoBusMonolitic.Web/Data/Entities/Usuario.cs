using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Usuario : BaseEntity
    {
        // atributos de la entidad 
        public int IdUsuario { get; set; }
        public string Nombre;
        public string Apellidos;
        public string Correo;
        public string Clave;
        public string TipoUsuario;
        public DateTime FechaCreacion;

        
    }
}
