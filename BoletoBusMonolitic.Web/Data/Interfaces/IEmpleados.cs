using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IEmpleados
    {
        List<Empleados> GetEmpleadosList();

        public void AgregarEmpleado();

        public void EliminarEmpleados();

        public void MostrarEmpleados();
    }
}
//Angel Miguel de la Rosa