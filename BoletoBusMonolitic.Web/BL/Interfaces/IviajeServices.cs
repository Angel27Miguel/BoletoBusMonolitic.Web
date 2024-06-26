using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IViajeService
    {
        ServiceResult GetViajes();
        ServiceResult GetViaje(int id);

        ServiceResult EditarViaje(ViajeEditarModel viajeEditar);

        ServiceResult EliminarViaje(ViajeEliminarModel viajeEliminar);

        ServiceResult GuardarViaje(ViajeGuardarModel viajeGuardar);
    }
}
