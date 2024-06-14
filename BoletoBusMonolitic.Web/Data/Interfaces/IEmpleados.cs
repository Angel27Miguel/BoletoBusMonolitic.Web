using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public interface IEmpleados
    {
        List<EmpleadosModel> GetEmpleados();

        void GuardarEmpleado( EmpleadosGuardarModel empleadosGuardar);

        void EliminarEmpleados(EmpleadosEliminarModel empleadosEliminar);

        void EditarEmpleados(EmpleadosEditarModel empleadosEditar);

 
        EmpleadosModel GetEmpleado(int IdEmpleado);
        
    }
}
//Angel Miguel de la Rosa