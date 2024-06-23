using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interfaces
{
	public interface IReservaDetalleServices
	{
		List<ReservaDetalleModel> GetReservaDetalles();
	}
}