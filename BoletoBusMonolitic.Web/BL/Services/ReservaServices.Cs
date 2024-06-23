using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
	public class ReservaServices : IReservaServices
	{
		private readonly IReservaServices reserva;

		public ReservaServices(IReservaServices reserva)
		{
			this.reserva = reserva;
		}

		public List<ReservaModel> GetReservaModels()
		{
			return this.reserva.GetReservaModels();
		}

	}
}
