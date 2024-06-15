using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IBus
    {
        List<BusModel> GetBusList();

        BusModel GetBusModel(int idBus);
        public void GuardarBus(BusGuardarModel busGuardar);

        public void EliminarBus(BusEliminarModel busEliminar);

        public void EditarBus(BusEditarModel busEditar);


        
    }
}

