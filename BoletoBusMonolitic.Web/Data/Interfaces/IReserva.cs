using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IReserva
    {
        List<Reserva> GetReservaList();

        public void GuardarReserva();

        public void EliminarReserva();
    }
}
//Angel Miguel de la Rosa