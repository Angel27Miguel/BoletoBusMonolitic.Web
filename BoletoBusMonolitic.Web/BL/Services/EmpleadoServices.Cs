using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
	public class EmpleadoServices : IEmpleadoServices
	{
		private readonly IEmpleados empleadoDb;

        public EmpleadoServices(IEmpleados empleadoDb)
        {
            this.empleadoDb = empleadoDb;
        }
		public ServiceResult GetEmpleados()
		{
			ServiceResult result = new ServiceResult();

			try
			{
				result.Data = empleadoDb.GetEmpleados();

			}
			catch (Exception ex)
			{
				result.Success = false;
				result.Message = "Ocurio un error obteniendo los empleados";
			}
			return result;
		}
		public ServiceResult GetEmpleado(int id)
		{
			ServiceResult result = new ServiceResult();
			try 
			{
				result.Data = this.empleadoDb.GetEmpleado(id);
			}
			catch (Exception ex)
			{
				result.Success = false;
				result.Message = "Ocurio un error editando los datos"; 
			}
			return result ;
		}


		public ServiceResult EditarEmpleado(EmpleadosEditarModel empleadoEditar)
		{
			ServiceResult result = new ServiceResult();

			try
			{
				if (empleadoEditar is null)
				{
					result.Success =false;
					result.Message = "El empleado no puede cer nulo.";
					return result ;
				}

				//if (empleadoEditar is null)
				//	throw new EmpleadoServicesException("El empleado no puede cer nulo.");
				

			}
			catch (Exception ex)
			{
				result.Success = false;
				result.Message = "Ocurio un error editando los datos";
			}
			return result;
		}

		public ServiceResult EliminarEmpleado(EmpleadosEliminarModel empleadoEliminar)
		{
			ServiceResult result = new ServiceResult();

			try
			{

			}
			catch (Exception ex)
			{
				result.Success = false;
				result.Message = "Ocurio un error eliminado los datos";
			}
			return result;
		}

		public ServiceResult GuardarrEmpleado(EmpleadosGuardarModel empleadoGuardar)
		{
			ServiceResult result = new ServiceResult();

			try
			{

			}
			catch (Exception ex)
			{
				result.Success = false;
				result.Message = "Ocurio un error guardando los datos";
			}
			return result;
		}
	}
}
