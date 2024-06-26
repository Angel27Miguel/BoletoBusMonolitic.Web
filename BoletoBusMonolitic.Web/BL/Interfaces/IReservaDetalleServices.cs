using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interfaces
{
	public interface IReservaDetalleServices
	{
		ServiceResult GetReservaDetalles();

		ServiceResult GetReservaDetalle(int id);

		ServiceResult GuardarReservaDetalle(ReservaDetalleModelGuardar reservaDetalleGuardar);

		ServiceResult EditarReservaDetalle(ReservaDetalleModelEdit reservaDetalleEdit);

    }
}