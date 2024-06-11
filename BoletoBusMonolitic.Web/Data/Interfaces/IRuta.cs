using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IRuta
    {
        List<RutaModel> GetRutaModels();

        RutaModel GetRutaModel(int idRuta);

        public void AgregarRuta(RutaAgregarModel rutaAgregar);

        public void EliminarRuta(RutaEliminarModel rutaEliminar);

        public void EditarRuta(RutaEditarModel rutaEditar);



    }
}

