using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IReservaDetalle
    {
        List<ReservaDetalleModel> GetReservaDetalleList();

        ReservaDetalleModel GetReservaDetalleModel(int IdReservaDetalle);
    }
}
//Angel Miguel de la Rosa