using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Exeptions;
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

		private Reserva GetReservaId(int idReserva)
		{
			var reserva = this.context.Reserva.Find(idReserva);
			if (reserva == null)
			{
				throw new ReservaException("Reserva no encontrada");
			}
			return reserva;
		}

		public void EditarReserva(ReservaEditarModel reservaEditar)
		{
			var reserva = GetReservaId(reservaEditar.IdReserva);

			reserva.IdViaje = reservaEditar.IdViaje;
			reserva.IdPasajero = reservaEditar.IdPasajero;
			reserva.AsientosReservados = reservaEditar.AsientosReservados;
			reserva.MontoTotal = reservaEditar.MontoTotal;

			this.context.Update(reserva);
			this.context.SaveChanges();
		}

		public void EliminarReserva(ReservaEliminarModel reservaEliminar)
		{
			var reserva = GetReservaId(reservaEliminar.IdReserva);

			this.context.Reserva.Remove(reserva);
			this.context.SaveChanges();
		}

		public ReservaModel GetReservaModel(int idReserva)
		{
			var reserva = GetReservaId(idReserva);

			return new ReservaModel()
			{
				IdReserva = reserva.IdReserva,
				IdViaje = reserva.IdViaje,
				IdPasajero = reserva.IdPasajero,
				AsientosReservados = reserva.AsientosReservados,
				MontoTotal = reserva.MontoTotal,
				FechaCreacion = reserva.FechaCreacion
			};
		}

		public List<ReservaModel> GetReservaList()
		{
			return this.context.Reserva.OrderByDescending(e => e.FechaCreacion).Select(reserva => new ReservaModel()
			{
				IdReserva = reserva.IdReserva,
				IdViaje = reserva.IdViaje,
				IdPasajero = reserva.IdPasajero,
				AsientosReservados = reserva.AsientosReservados,
				MontoTotal = reserva.MontoTotal,
				FechaCreacion = reserva.FechaCreacion
			}).ToList();
		}

		public void GuardarReserva(ReservaGuardarModel reservaGuardar)
		{
			Reserva reserva = new()
			{
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