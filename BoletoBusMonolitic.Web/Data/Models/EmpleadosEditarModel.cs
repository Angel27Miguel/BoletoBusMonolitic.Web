using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class EmpleadosEditarModel
    {

        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get;}
    }
}
//Angel Miguel de la Rosa