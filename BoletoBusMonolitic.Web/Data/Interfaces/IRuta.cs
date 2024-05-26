using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IRuta
    {
        List<Ruta> GetRutaList();

        public void crearRuta();

        public void eliminarRuta();

        public void actualizarRuta();

        public void buscarRuta();
    }
}

