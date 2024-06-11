namespace BoletoBusMonolitic.Web.Data.Models
{
    public class UsuarioEditarModel
    {
        public int IdUsuario { get; set; } 

        public string Nombres { get; set; } 

        public string Apellidos { get; set; } 

        public string Correo { get; set; } 

        public string Clave { get; set; } 

        public string TipoUsuario { get; set; } 

        public DateTime? FechaCreacion { get; set; }
    }
}
