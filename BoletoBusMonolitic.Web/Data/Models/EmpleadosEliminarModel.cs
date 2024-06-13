using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class EmpleadosEliminarModel
    {
        
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
    }
}
//Angel Miguel de la Rosa