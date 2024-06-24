using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Usuario : BaseEntity
    {
        // atributos de la entidad 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public string? Nombre;
        public string? Apellidos;
        public string? Correo;
        public string? Clave;
        public string? TipoUsuario;
        public DateTime FechaCreacion;

        
    }
}
