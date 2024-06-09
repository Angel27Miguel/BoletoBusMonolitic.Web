using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Empleados : BaseEntity
    {
        //Atributos de la entidad 

       public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }


    }
}
//Angel Miguel de la Rosa