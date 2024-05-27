using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Empleados : BaseEntity
    {
        //Atributos de la entidad 

        private string Nombre;
        private string Cargo;

        public Empleados(int id, string nombre, string cargo) : base(id)
        {
            this.Nombre = nombre;
            this.Cargo = cargo;
        }
    }
}
//Angel Miguel de la Rosa