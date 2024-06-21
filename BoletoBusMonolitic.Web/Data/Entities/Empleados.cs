using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Empleados 
    {
		#region "Atributos"

		[Key]
        public int IdEmpleado { get; set; }

        public string? Nombre { get; set; }
        
        public string? Cargo { get; set; }

		#endregion
	}
}
//Angel Miguel de la Rosa