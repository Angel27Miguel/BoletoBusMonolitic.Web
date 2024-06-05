using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IEmpleados
    {
        List<Empleados> GetEmpleadosList();

        void GuardarEmpleado( EmpleadosGuardarModel empleadosGuardar);

        void EliminarEmpleados(EmpleadosEliminarModel empleadosEliminar);

        void EditarEmpleados(EmpleadosEditarModel empleadosEditar);

        EmpleadosModel GetEmpleados(int IdEmpleado);
    }
}
//Angel Miguel de la Rosa