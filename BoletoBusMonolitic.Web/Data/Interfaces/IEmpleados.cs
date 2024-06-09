using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IEmpleados
    {
        List<EmpleadosModel> GetEmpleadosList();

        void GuardarEmpleado( EmpleadosGuardarModel empleadosGuardar);

        void EliminarEmpleados(EmpleadosEliminarModel empleadosEliminar);

        void EditarEmpleados(EmpleadosEditarModel empleadosEditar);

 
        EmpleadosModel GetEmpleado(int IdEmpleado);
    }
}
//Angel Miguel de la Rosa