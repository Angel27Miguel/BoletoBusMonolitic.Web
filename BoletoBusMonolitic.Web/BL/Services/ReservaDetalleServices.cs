using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
	public class ReservaDetalleServices : IReservaDetalleServices
	{
		private readonly IReservaDetalleServices reservaDetalle;
        private readonly ILogger logger;
        public ReservaDetalleServices(IReservaDetalleServices reservaDetalle, ILogger logger)
        {
            this.logger = logger;
			this.reservaDetalle = reservaDetalle;
            
        }

        public ServiceResult EditarReservaDetalle(ReservaDetalleModelEdit reservaDetalleEdit)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetReservaDetalle(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetReservaDetalles()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GuardarReservaDetalle(ReservaDetalleModelGuardar reservaDetalleGuardar)
        {
            throw new NotImplementedException();
        }
    }
}
