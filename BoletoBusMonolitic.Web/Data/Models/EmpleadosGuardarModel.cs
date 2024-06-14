using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class EmpleadosGuardarModel
    {
        [Key]
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
        }
}
//Angel Miguel de la Rosa