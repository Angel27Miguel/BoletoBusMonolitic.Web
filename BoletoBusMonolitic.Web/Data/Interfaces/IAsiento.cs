using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IAsiento
    {
        List<AsientoModel> GetAsientoList();
        AsientoModel GetAsientoModel(int idAsiento);

        public void GuardarAsiento(AsientoGuardarModel asientoAgregar);

        public void EliminarAsiento(AsientoEliminarModel asientoEliminar);
        
        public void EditarAsiento(AsientoEditarModel asientoEditar);



        
    }
}
