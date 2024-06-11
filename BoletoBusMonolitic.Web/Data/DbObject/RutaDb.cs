using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

using BoletoBusMonolitic.Web.Data.Context;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class RutaDb : IRuta
    {

        private readonly BoletoBusContext context;
        private readonly EmpleadosException exception;
        public void actualizarRuta()
        {
            throw new NotImplementedException();
        }

        public void AgregarRuta(RutaAgregarModel rutaAgregar)
        {
            throw new NotImplementedException();
        }

        public void buscarRuta()
        {
            throw new NotImplementedException();
        }

        public void crearRuta()
        {
            throw new NotImplementedException();
        }

        public void EditarRuta(RutaEditarModel rutaEditar)
        {
            throw new NotImplementedException();
        }

        public void eliminarRuta()
        {
            throw new NotImplementedException();
        }

        public void EliminarRuta(RutaEliminarModel rutaEliminar)
        {
            throw new NotImplementedException();
        }

        public List<Ruta> GetRutaList()
        {
            throw new NotImplementedException();
        }

        public RutaModel GetRutaModel(int idRuta)
        {
            throw new NotImplementedException();
        }

        public List<RutaModel> GetRutaModels()
        {
            throw new NotImplementedException();
        }
    }
}
