using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Date.Daos
{
    public class ViajeDb : IViajeDb
    {
        private readonly BoletoBusContext context;
        private readonly ViajeException exception;
        private Viaje viaje;

        public ViajeDb(BoletoBusContext context, ViajeException exception)
        {
            this.context = context;
            this.exception = exception;
        }
        public void EditarViaje(ViajeEditarModel viajeEditar)
        {
            var viaje = this.context.Viajes.Find(viajeEditar);
            if (viaje == null)
            {
                exception.ErrorMessage();
            }
            Viaje viaje2 = new Viaje()
            {

                ViajeId = viajeEditar.IdViaje,
                IdBus = viajeEditar.IdBus,
                Bus = viajeEditar.Bus,
                IdRuta = viajeEditar.IdRuta,
                IdPasajero = viajeEditar.IdPasajero,
                Pasajero = viajeEditar.Pasajero,
                Ruta = viajeEditar.Ruta,
                FechaSalida = viajeEditar.FechaSalida,
                HoraSalida = viajeEditar.HoraSalida,
                FechaLlegada = viajeEditar.FechaLlegada,
                HoraLlegada = viajeEditar.HoraLlegada,
                Precio = viajeEditar.Precio,

            };
        }

        public void EliminarViaje(ViajeEliminarModel viajeEliminar)
        {
            var viaje = this.context.Viajes.Find(viajeEliminar);
            if (viaje == null)
            {
                exception.ErrorMessage();
            }


        }

        public ViajeModel GetViaje(int IdViaje)
        {
            var viaje = this.context.Viajes.Find(IdViaje);

            ViajeModel viajeModel = new ViajeModel()
            {
                ViajeId = viaje.ViajeId,
                IdBus = viaje.IdBus,
                Bus = viaje.Bus,
                IdRuta = viaje.IdRuta,
                IdPasajero = viaje.IdPasajero,
                Pasajero = viaje.Pasajero,
                Ruta = viaje.Ruta,
                FechaSalida = viaje.FechaSalida,
                HoraSalida = viaje.HoraSalida,
                FechaLlegada = viaje.FechaLlegada,
                HoraLlegada = viaje.HoraLlegada,
                Precio = viaje.Precio,
                TotalAsiento = viaje.TotalAsiento,
                AsientosDisponibles = viaje.AsientosDisponibles,
                FechaCreacion = viaje.FechaCreacion
            };

            return viajeModel;

        }

        public List<Viaje> GetViajeList()
        {
            throw new NotImplementedException();
        }

        public void GuardarViaje(ViajeGuardarModel viajeGuardar)
        {
            Viaje viaje = new Viaje()
            {

                IdBus = viajeGuardar.IdBus,
                Bus = viajeGuardar.Bus,
                IdRuta = viajeGuardar.IdRuta,
                IdPasajero = viajeGuardar.IdPasajero,
                Pasajero = viajeGuardar.Pasajero,
                Ruta = viajeGuardar.Ruta,
                FechaSalida = viajeGuardar.FechaSalida,
                HoraSalida = viajeGuardar.HoraSalida,
                FechaLlegada = viajeGuardar.FechaLlegada,
                HoraLlegada = viajeGuardar.HoraLlegada,
                Precio = viajeGuardar.Precio,

            };
            this.context.Viajes.Add(viaje);
            this.context.SaveChanges();
        }


    }
}
//Angel Miguel de la Rosa