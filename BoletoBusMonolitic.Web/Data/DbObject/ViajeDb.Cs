using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Date.Daos
{
	public class ViajeDb : IViajeDb
	{
		private readonly BoletoBusContext context;

		public ViajeDb(BoletoBusContext context)
		{
			this.context = context;
		}

		private Viaje GetViajeId(int idViaje)
		{
			var viaje = this.context.Viaje.Find(idViaje);
			if (viaje == null)
			{
				throw new ViajeException("Viaje no encontrado");
			}
			return viaje;
		}

		public void EditarViaje(ViajeEditarModel viajeEditar)
		{
			var viaje = GetViajeId(viajeEditar.IdViaje);

			viaje.IdBus = viajeEditar.IdBus;
			viaje.IdRuta = viajeEditar.IdRuta;
			viaje.FechaSalida = viajeEditar.FechaSalida;
			viaje.HoraSalida = viajeEditar.HoraSalida;
			viaje.FechaLlegada = viajeEditar.FechaLlegada;
			viaje.HoraLlegada = viajeEditar.HoraLlegada;
			viaje.Precio = viajeEditar.Precio;
			viaje.TotalAsientos = viajeEditar.TotalAsientos;
			viaje.AsientosReservados = viajeEditar.AsientosReservados;

			this.context.Viaje.Update(viaje);
			this.context.SaveChanges();
		}

		public void EliminarViaje(ViajeEliminarModel viajeEliminar)
		{
			var viaje = GetViajeId(viajeEliminar.IdViaje);

			this.context.Viaje.Remove(viaje);
			this.context.SaveChanges();
		}

		public ViajeModel GetViaje(int idViaje)
		{
			var viaje = GetViajeId(idViaje);

			return new ViajeModel()
			{
				IdViaje = viaje.IdViaje,
				IdBus = viaje.IdBus,
				IdRuta = viaje.IdRuta,
				FechaSalida = viaje.FechaSalida,
				HoraSalida = viaje.HoraSalida,
				FechaLlegada = viaje.FechaLlegada,
				HoraLlegada = viaje.HoraLlegada,
				Precio = viaje.Precio,
				TotalAsientos = viaje.TotalAsientos,
				AsientosReservados = viaje.AsientosReservados,
				AsientoDisponibles = viaje.AsientoDisponibles,
				FechaCreacion = viaje.FechaCreacion
			};
		}

		public List<ViajeModel> GetViajeModels()
		{
			return this.context.Viaje.OrderByDescending(e => e.FechaCreacion).Select(viaje => new ViajeModel()
			{
				IdViaje = viaje.IdViaje,
				IdBus = viaje.IdBus,
				IdRuta = viaje.IdRuta,
				FechaSalida = viaje.FechaSalida,
				HoraSalida = viaje.HoraSalida,
				FechaLlegada = viaje.FechaLlegada,
				HoraLlegada = viaje.HoraLlegada,
				Precio = viaje.Precio,
				TotalAsientos = viaje.TotalAsientos,
				AsientoDisponibles = viaje.AsientoDisponibles,
				AsientosReservados = viaje.AsientosReservados,
				FechaCreacion = viaje.FechaCreacion
			}).ToList();
		}

		public void GuardarViaje(ViajeGuardarModel viajeGuardar)
		{
			Viaje viaje = new()
			{
				IdBus = viajeGuardar.IdBus,
				IdRuta = viajeGuardar.IdRuta,
				FechaSalida = viajeGuardar.FechaSalida,
				HoraSalida = viajeGuardar.HoraSalida,
				FechaLlegada = viajeGuardar.FechaLlegada,
				HoraLlegada = viajeGuardar.HoraLlegada,
				Precio = viajeGuardar.Precio,
				TotalAsientos = viajeGuardar.TotalAsientos,
				AsientosReservados = viajeGuardar.AsientosReservados,
				FechaCreacion = viajeGuardar.FechaCreacion
			};

			this.context.Viaje.Add(viaje);
			this.context.SaveChanges();
		}
	}
}

//Angel Miguel de la Rosa