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
       

        public ReservaDb(BoletoBusContext context)
        {
            this.context = context;
        }
        public void EditarReserva(ReservaEditarModel reservaEditar)
        {
            var editarReserva = this.context.Reserva.Find(reservaEditar.IdReserva);
            if (editarReserva == null) {
                throw new ArgumentException("Reserva no encontrado");
            }

           editarReserva.IdViaje = reservaEditar.IdViaje;
            editarReserva.IdReserva = reservaEditar.IdReserva;
            editarReserva.IdPasajero = reservaEditar.IdPasajero;
            editarReserva.AsientosReservados = reservaEditar.AsientosReservados;
            editarReserva.MontoTotal = reservaEditar.MontoTotal;

            this.context.Update(editarReserva);
            this.context.SaveChanges();

        }

       

        public void EliminarReserva(ReservaEliminarModel reservaEliminar)
        {
            var eliminarReserva = this.context.Reserva.Find(reservaEliminar.IdReserva);
            if (eliminarReserva == null)
            {
                throw new ArgumentException("Reserva no encontrada");
            }

            this.context.Reserva.Remove(eliminarReserva);
            this.context.SaveChanges();
        }

        public List<ReservaModel> GetReservaList()
        {
            return this.context.Reserva.OrderByDescending(e => e.FechaCreacion).Select(cd => new ReservaModel()
            {
                IdReserva = cd.IdReserva,
                IdViaje = cd.IdViaje,
                IdPasajero= cd.IdPasajero,
                AsientosReservados = cd.AsientosReservados,
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
                AsientosReservados= reserva.AsientosReservados,
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
                AsientosReservados = reservaGuardar.AsientosReservados,
                MontoTotal = reservaGuardar.MontoTotal,
                FechaCreacion = reservaGuardar.FechaCreacion
               

             };
            this.context.Add(reserva);
            this.context.SaveChanges();
        }
    }
}
//Angel Miguel de la Rosa