using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IBus
    {
        List<BusModel> GetBusModels();

        BusModel GetBusModel(int idBus);
        public void AgregarBus(BusGuardarModel busGuardar);

        public void EliminarBus(BusEliminarModel busEliminar);

        public void EditarBus(BusEditarModel busEditar);


        
    }
}

