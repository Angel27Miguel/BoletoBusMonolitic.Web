using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class ReservaDb : IReserva
    {
        private readonly BoletoBusContext context;
        private readonly ReservaException exception;
        private Reserva reserva;

        public ReservaDb(BoletoBusContext context, ReservaException exception)
        {
            this.context = context;
            this.exception = exception;
        }
        public void EditarReserva(ReservaEditarModel reservaEditar)
        {
            throw new NotImplementedException();
        }

        public void EliminarReserva(ReservaEliminarModel reservaEliminar)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> GetReservaList()
        {
            throw new NotImplementedException();
        }

        public ReservaModel GetReservaModel(int IdReserva)
        {
            throw new NotImplementedException();
        }

        public void GuardarReserva(ReservaGuardarModel reservaGuardar)
        {
            throw new NotImplementedException();
        }
    }
}
//Angel Miguel de la Rosa