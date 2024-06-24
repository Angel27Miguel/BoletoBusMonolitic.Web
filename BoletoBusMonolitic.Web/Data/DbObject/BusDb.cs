﻿using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class BusDb : IBus
    {
        private readonly BoletoBusContext context;

        public BusDb(BoletoBusContext context)
        {
            this.context = context;


        }
        public BusModel GetBusModel(int IdBus)
        {
            var bus = this.context.Bus.Find(IdBus);

            if (bus == null)
            {
                throw new ArgumentNullException("Este bus no se encuentra registrado");
            }

            return new BusModel
            {
                IdBus = bus.IdBus,
                
                Nombre = bus.Nombre,

                disponible = bus.Disponible
            };
        }

        public void GuardarBus(BusGuardarModel busGuardar)
        {
            Bus bus = new Bus()
            {
                NumeroPlaca = busGuardar.NumeroPlaca,
                Nombre = busGuardar.Nombre,
                CapacidadPiso1 = busGuardar.CapacidadPiso1,
                CapacidadPiso2 = busGuardar.CapacidadPiso2,
                Disponible = busGuardar.Disponible,
                FechaCreacion = busGuardar.FechaCreacion
            };

            this.context.Bus.Add(bus);
            this.context.SaveChanges();
        }

        public void EditarBus(BusEditarModel busEditar)
        {
            var bus = this.context.Bus.Find(busEditar.IdBus);
            
            if (bus == null)
            {

                throw new ArgumentNullException("Bus no encontrado");
            }

            bus.IdBus = busEditar.IdBus;
            bus.NumeroPlaca = busEditar.NumeroPlaca;
            bus.Nombre = busEditar.Nombre;
            bus.CapacidadPiso1 = busEditar.CapacidadPiso1;
            bus.CapacidadPiso2 = busEditar.CapacidadPiso2;
            bus.Disponible = busEditar.Disponible;

            this.context.Bus.Update(bus);  
            this.context.SaveChanges();
        }

        public void EliminarBus(BusEliminarModel busEliminar)
        {
            var busModelEliminar = this.context.Bus.Find(busEliminar.IdBus);
            if (busModelEliminar == null)
            {
                throw new ArgumentNullException("Bus no encontrado");
            }

            busModelEliminar.IdBus = busEliminar.IdBus;

            this.context.Remove(busModelEliminar);
            this.context.SaveChanges();
        }



        public List<BusModel> GetBusList()
        {
            return this.context.Bus.Select(bu => new BusModel()
            {
                IdBus = bu.IdBus,

                Nombre = bu.Nombre,

                disponible = bu.Disponible


            }).ToList();

        }
            
    }
}
    
