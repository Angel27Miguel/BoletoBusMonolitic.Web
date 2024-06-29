using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IRutaServices
    {
        ServiceResult GetRutaList();

        ServiceResult GetRutaModel(int idRuta);

        ServiceResult GuardarRuta(RutaGuardarModel rutaAgregar);

        ServiceResult EliminarRuta(RutaEliminarModel rutaEliminar);

        ServiceResult EditarRuta(RutaEditarModel rutaEditar);
    }
}
