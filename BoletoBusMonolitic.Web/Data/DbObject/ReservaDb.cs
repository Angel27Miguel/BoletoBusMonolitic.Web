using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class ReservaDb : IReserva
    {
        private readonly BoletoBusContext context;
        private readonly ReservaException exception1;
       

        public ReservaDb(BoletoBusContext context, ReservaException exception1)
        {
            this.context = context;
            this.exception1 = exception1;
        }
        public void EditarReserva(ReservaEditarModel reservaEditar)
        {
            var editarReserva = this.context.Reserva.Find(reservaEditar);
            if (editarReserva == null) { }

           editarReserva.IdViaje = reservaEditar.IdViaje;
            editarReserva.IdReserva = reservaEditar.IdReserva;
            editarReserva.IdPasajero = reservaEditar.IdPasajero;
            editarReserva.AsientoReservado = reservaEditar.AsientoReservado;
            editarReserva.MontoTotal = reservaEditar.MontoTotal;

            this.context.Update(editarReserva);
            this.context.SaveChanges();

        }

        public void EliminarReserva(ReservaEliminarModel reservaEliminar)
        {
            var eliminarReserva = this.context.Reserva.Find(reservaEliminar);
            if (eliminarReserva == null) { }

            eliminarReserva.IdReserva = reservaEliminar.IdReserva;
            eliminarReserva.IdPasajero = reservaEliminar.IdPasajero;
            

            this.context.Update(eliminarReserva);
            this.context.SaveChanges();
        }

        public List<ReservaModel> GetReservaList()
        {
            return this.context.Reserva.Select(cd => new ReservaModel()
            {
                IdReserva = cd.IdReserva,
                IdViaje = cd.IdViaje,
                IdPasajero = cd.IdPasajero,
                AsientoReservado = cd.AsientoReservado,
                MontoTotal = cd.MontoTotal,
                FechaCreacion = cd.FechaCreacion

            }).ToList();
        }

        public ReservaModel GetReservaModel(int IdReserva)
        {
            var reserva = this.context.Reserva.Find(IdReserva);

            ArgumentNullException.ThrowIfNull(reserva, "Reserva no encontrado");

            ReservaModel reservaModel = new ()
            {
                IdReserva = reserva.IdReserva,
                IdViaje = reserva.IdViaje,
                IdPasajero = reserva.IdPasajero,
                AsientoReservado= reserva.AsientoReservado,
                MontoTotal = reserva.MontoTotal,
                FechaCreacion = reserva.FechaCreacion
                
            };
            return reservaModel;
        }

        public void GuardarReserva(ReservaGuardarModel reservaGuardar)
        {
            Reserva reserva = new Reserva() {

                IdViaje = reservaGuardar.IdViaje,
                IdPasajero = reservaGuardar.IdPasajero,
                AsientoReservado = reservaGuardar.AsientoReservado,
                MontoTotal = reservaGuardar.MontoTotal

             };
            this.context.Add(reserva);
            this.context.SaveChanges();
        }
    }
}
//Angel Miguel de la Rosa