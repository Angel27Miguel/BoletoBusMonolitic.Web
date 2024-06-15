using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Usuario : BaseEntity
    {
        // atributos de la entidad 
        
        private string nombre;
        private string apellidos;
        private string correo;
        private string clave;
        private string TipoUsuario;
        private DateTime fechaCreacion;

        
    }
}
