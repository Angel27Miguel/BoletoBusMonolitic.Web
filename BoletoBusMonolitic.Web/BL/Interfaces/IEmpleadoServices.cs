using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interfaces
{
	public interface IEmpleadoServices
	{
		ServiceResult GetEmpleados();
		ServiceResult GetEmpleado(int id);

		ServiceResult EditarEmpleado(EmpleadosEditarModel empleadoEditar);

		ServiceResult EliminarEmpleado(EmpleadosEliminarModel empleadoEliminar);

		ServiceResult GuardarrEmpleado(EmpleadosGuardarModel empleadoGuardar);
	}
}
