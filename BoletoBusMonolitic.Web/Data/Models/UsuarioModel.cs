namespace BoletoBusMonolitic.Web.Data.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
