using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
	public class EmpleadoServices : IEmpleadoServices
	{
		private readonly IEmpleadoServices empleadoServices;

        public EmpleadoServices(IEmpleadoServices empleadoServices)
        {
            this.empleadoServices = empleadoServices;
        }

		public List<EmpleadosModel> GetEmpleadosModels()
		{
			return this.empleadoServices.GetEmpleadosModels();
		}
	}
}
