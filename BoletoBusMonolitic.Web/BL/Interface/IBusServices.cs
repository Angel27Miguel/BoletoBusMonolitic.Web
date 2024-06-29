using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IBusServices
    {

        ServiceResult GetBusList();

        ServiceResult GetBusModel(int idBus);
        ServiceResult GuardarBus(BusGuardarModel busGuardar);

        ServiceResult EliminarBus(BusEliminarModel busEliminar);

        ServiceResult EditarBus(BusEditarModel busEditar);

    }
}
