using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Entities;
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
        public void EditarViaje(ViajeEditarModel viajeEditar)
        {
            var viajeEdita = this.context.Viaje.Find(viajeEditar);
            if (viajeEdita == null)
            {
                throw new ArgumentException("Viaje no encontrado");
            }


            viajeEdita.IdBus = viajeEditar.IdBus;
            viajeEdita.IdRuta = viajeEditar.IdRuta;
            viajeEdita.IdPasajero = viajeEditar.IdPasajero;
            viajeEdita.FechaSalida = viajeEditar.FechaSalida;
            viajeEdita.HoraSalida = viajeEditar.HoraSalida;
            viajeEdita.FechaLlegada = viajeEditar.FechaLlegada;
            viajeEdita.HoraLlegada = viajeEditar.HoraLlegada;
            viajeEdita.Precio = viajeEditar.Precio;

            this.context.Viaje.Update(viajeEdita);
            this.context.SaveChanges();

        }

        public void EliminarViaje(ViajeEliminarModel viajeEliminar)
        {
            var viajeEliminarModel = this.context.Viaje.Find(viajeEliminar.IdViaje);
            if (viajeEliminarModel == null)
            {
                throw new ArgumentException("Viaje no encontrado");
                
            }

            
            viajeEliminarModel.IdViaje = viajeEliminar.IdViaje;

            this.context.Viaje.Remove(viajeEliminarModel);
            this.context.SaveChanges();

        }

        public ViajeModel GetViaje(int IdViaje)
        {
            var viaje = this.context.Viaje.Find(IdViaje);

            ArgumentNullException.ThrowIfNull(viaje,"Viaje no encontrado");

            ViajeModel viajeModel = new ViajeModel()
            {
  
                IdBus = viaje.IdBus,
                IdRuta = viaje.IdRuta,
                IdPasajero = viaje.IdPasajero,
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

        public List<ViajeModel> GetViajeModels()
        {
            return this.context.Viaje.Select(cd => new ViajeModel()
            {
                IdViaje = cd.IdViaje,
                IdBus = cd.IdBus,
                IdPasajero = cd.IdPasajero,
                IdRuta = cd.IdRuta,
                FechaSalida = cd.FechaSalida,
                FechaLlegada = cd.FechaSalida,
                Precio = cd.Precio,
                TotalAsiento = cd.TotalAsiento,
                AsientosDisponibles = cd.AsientosDisponibles,
                FechaCreacion = cd.FechaCreacion

              }).ToList();
        }

        public void GuardarViaje(ViajeGuardarModel viajeGuardar)
        {
            Viaje viaje = new Viaje()
            {

                IdBus = viajeGuardar.IdBus,
                IdRuta = viajeGuardar.IdRuta,
                IdPasajero = viajeGuardar.IdPasajero,
                FechaSalida = viajeGuardar.FechaSalida,
                HoraSalida = viajeGuardar.HoraSalida,
                FechaLlegada = viajeGuardar.FechaLlegada,
                HoraLlegada = viajeGuardar.HoraLlegada,
                Precio = viajeGuardar.Precio,

            };
            this.context.Viaje.Add(viaje);
            this.context.SaveChanges();
        }


    }
}
//Angel Miguel de la Rosa