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

        public void EditarReservaDetalle(ReservaDetalleModelEdit reservaEditar)
        {
            var editarReserva = this.context.ReservaDetalle.Find(reservaEditar.IdReservaDetalle);
            if (editarReserva == null)
            {
                throw new ArgumentException("Reserva no encontrado");
            }

            editarReserva.IdReserva = reservaEditar.IdReserva;
            editarReserva.IdAsiento = reservaEditar.IdAsiento;
            editarReserva.FechaCreacion = reservaEditar.FechaCreacion;
            

            this.context.Update(editarReserva);
            this.context.SaveChanges();
        }

        public List<ReservaDetalleModel> GetReservaDetalleList()
        {
            return this.context.ReservaDetalle.OrderByDescending(e => e.FechaCreacion).Select(crd => new ReservaDetalleModel()
            {
                IdReservaDetalle = crd.IdReservaDetalle,
                IdReserva = crd.IdReserva,
                IdAsiento = crd.IdAsiento,
                FechaCreacion = crd.FechaCreacion

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

        public void GuardarReservaDetalle(ReservaDetalleModelGuardar reservaGuardar)
        {
            ReservaDetalle reserva = new ReservaDetalle()
            {

                IdReserva = reservaGuardar.IdReserva,
                IdAsiento = reservaGuardar.IdAsiento,
                FechaCreacion = reservaGuardar.FechaCreacion
          


            };
            this.context.Add(reserva);
            this.context.SaveChanges();
        }

    }
    
}
//Angel Miguel de la Rosa