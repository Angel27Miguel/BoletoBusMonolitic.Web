using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class ReservaDetalleDb : IReservaDetalle
    {
        private readonly BoletoBusContext context;
       

        public ReservaDetalleDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public List<ReservaDetalleModel> GetReservaDetalleList()
        {
            return this.context.ReservaDetalle.Select(cd => new ReservaDetalleModel()
            {
                IdReservaDetalle = cd.IdReservaDetalle,
                IdReserva = cd.IdReserva,
                IdAsiento = cd.IdAsiento,
                FechaCreacion = cd.FechaCreacion

    }).ToList();
        }

        public ReservaDetalleModel GetReservaDetalleModel(int IdReservaDetalle)
        {
            var reserva = this.context.ReservaDetalle.Find(IdReservaDetalle);

            ArgumentNullException.ThrowIfNull(reserva, "Reserva no encontrado");

            ReservaDetalleModel reservaModel = new ReservaDetalleModel()
            {
                IdReservaDetalle = reserva.IdReservaDetalle,
                IdReserva = reserva.IdReserva,
                IdAsiento = reserva.IdAsiento,
                FechaCreacion = reserva.FechaCreacion

            };
            return reservaModel;
        }
    }
}
//Angel Miguel de la Rosa