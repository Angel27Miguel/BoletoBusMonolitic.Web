using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public interface IReservaDetalle
    {
        List<ReservaDetalleModel> GetReservaDetalleList();

        ReservaDetalleModel GetReservaDetalleModel(int IdReservaDetalle);

        void GuardarReservaDetalle(ReservaDetalleModelGuardar reservaGuardar);

        void EditarReservaDetalle(ReservaDetalleModelEdit reservaEditar);
    }
}
//Angel Miguel de la Rosa