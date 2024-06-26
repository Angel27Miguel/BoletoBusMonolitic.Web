using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interfaces
{
	public interface IReservaServices
	{
		ServiceResult GetReservas();
        ServiceResult GetReserva(int id);

        ServiceResult EditarReserva(ReservaEditarModel reservaEditar);

        ServiceResult EliminarReserva(ReservaEliminarModel reservaEliminar);

        ServiceResult GuardarReserva(ReservaGuardarModel reservaGuardar);
    }
}
