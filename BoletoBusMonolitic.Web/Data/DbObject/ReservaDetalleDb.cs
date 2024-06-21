using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Exeptions;
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

		private ReservaDetalle GetReservaDetalleId(int idReservaDetalle)
		{
			var reservaDetalle = this.context.ReservaDetalle.Find(idReservaDetalle);
			if (reservaDetalle == null)
			{
				throw new ReservaDetalleException("Reserva no encontrada");
			}
			return reservaDetalle;
		}

		public void EditarReservaDetalle(ReservaDetalleModelEdit reservaEditar)
		{
			var reservaDetalle = GetReservaDetalleId(reservaEditar.IdReservaDetalle);

			reservaDetalle.IdReserva = reservaEditar.IdReserva;
			reservaDetalle.IdAsiento = reservaEditar.IdAsiento;
			reservaDetalle.FechaCreacion = reservaEditar.FechaCreacion;

			this.context.Update(reservaDetalle);
			this.context.SaveChanges();
		}

		public List<ReservaDetalleModel> GetReservaDetalleList()
		{
			return this.context.ReservaDetalle.OrderByDescending(e => e.FechaCreacion).Select(reservaDetalle => new ReservaDetalleModel()
			{
				IdReservaDetalle = reservaDetalle.IdReservaDetalle,
				IdReserva = reservaDetalle.IdReserva,
				IdAsiento = reservaDetalle.IdAsiento,
				FechaCreacion = reservaDetalle.FechaCreacion
			}).ToList();
		}

		public ReservaDetalleModel GetReservaDetalleModel(int idReservaDetalle)
		{
			var reservaDetalle = GetReservaDetalleId(idReservaDetalle);

			return new ReservaDetalleModel()
			{
				IdReservaDetalle = reservaDetalle.IdReservaDetalle,
				IdReserva = reservaDetalle.IdReserva,
				IdAsiento = reservaDetalle.IdAsiento,
				FechaCreacion = reservaDetalle.FechaCreacion
			};
		}

		public void GuardarReservaDetalle(ReservaDetalleModelGuardar reservaGuardar)
		{
			ReservaDetalle reservaDetalle = new()
			{
				IdReserva = reservaGuardar.IdReserva,
				IdAsiento = reservaGuardar.IdAsiento,
				FechaCreacion = reservaGuardar.FechaCreacion
			};

			this.context.Add(reservaDetalle);
			this.context.SaveChanges();
		}
	}
}

//Angel Miguel de la Rosa