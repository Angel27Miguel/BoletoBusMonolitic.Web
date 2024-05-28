using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IReservaDetalle
    {
        List<ReservaDetalle> GetReservaDetalleList();

        public void Mostrar();
    }
}
//Angel Miguel de la Rosa