using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IAsientoServices
    {

            ServiceResult GetAsientoList();
            ServiceResult GetAsientoModel(int idAsiento);

            ServiceResult GuardarAsiento(AsientoGuardarModel asientoAgregar);

            ServiceResult EliminarAsiento(AsientoEliminarModel asientoEliminar);

            ServiceResult EditarAsiento(AsientoEditarModel asientoEditar);




        
    }
}
