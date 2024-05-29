using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IBus
    {
        List<Bus> GetBusList();
        public void agregarBus();

        public void eliminarBus();

        public void actualizarBus();

        public void buscarBus();
    }
}

