using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IRuta
    {
        List<RutaModel> GetRutaList();

        RutaModel GetRutaModel(int idRuta);

        public void GuardarRuta(RutaGuardarModel rutaAgregar);

        public void EliminarRuta(RutaEliminarModel rutaEliminar);

        public void EditarRuta(RutaEditarModel rutaEditar);



    }
}

