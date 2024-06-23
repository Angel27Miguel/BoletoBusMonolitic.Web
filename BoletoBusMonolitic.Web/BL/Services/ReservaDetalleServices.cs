using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
	public class ReservaDetalleServices : IReservaDetalleServices
	{
		private readonly IReservaDetalleServices reservaDetalle;
        public ReservaDetalleServices(IReservaDetalleServices reservaDetalle)
        {
			this.reservaDetalle = reservaDetalle;
            
        }
        public List<ReservaDetalleModel> GetReservaDetalles()
		{
			return this.reservaDetalle.GetReservaDetalles();
		}
	}
}
