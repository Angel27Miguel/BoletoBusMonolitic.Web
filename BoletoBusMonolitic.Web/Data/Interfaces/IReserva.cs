using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public interface IReserva
    {
        List<ReservaModel> GetReservaList();

        public void GuardarReserva(ReservaGuardarModel reservaGuardar);

        public void EliminarReserva(ReservaEliminarModel reservaEliminar);

        void EditarReserva(ReservaEditarModel reservaEditar);

        ReservaModel GetReservaModel(int IdReserva);
    }
}
//Angel Miguel de la Rosa