using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class ReservaDetalleDb : IReservaDetalle
    {
        private readonly BoletoBusContext context;
        private readonly ReservaDetalleException exception;
        private ReservaDetalle reservaDetalle;

        public ReservaDetalleDb(BoletoBusContext context, ReservaDetalleException exception)
        {
            this.context = context;
            this.exception = exception;
        }
        public List<ReservaDetalle> GetReservaDetalleList()
        {
            throw new NotImplementedException();
        }

        public ReservaDetalleModel GetReservaDetalleModel(int IdReservaDetalle)
        {
            throw new NotImplementedException();
        }
    }
}
//Angel Miguel de la Rosa