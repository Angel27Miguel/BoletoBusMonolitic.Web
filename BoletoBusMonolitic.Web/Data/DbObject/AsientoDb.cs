using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class AsientoDb : IAsiento
    {
        private readonly BoletoBusContext context;

        public AsientoDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public AsientoModel GetAsientoModel(int IdAsiento)
        {
            var asiento = this.context.Asiento.Find(IdAsiento);

            if (asiento == null)
            {
                throw new ArgumentNullException("Este asiento no se encuentra registrado");
            }

            return new AsientoModel
            {
                IdAsiento = asiento.IdAsiento,
                IdBus = asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            };
        }

        public void AgregarAsiento(AsientoAgregarModel asientoAgregar)
        {
            Asiento asiento = new Asiento()
            {
                IdBus = asientoAgregar.IdBus,
                NumeroPiso = asientoAgregar.NumeroPiso,
                NumeroAsiento = asientoAgregar.NumeroAsiento,
                FechaCreacion = asientoAgregar.FechaCreacion
            };

            this.context.Asiento.Add(asiento);
            this.context.SaveChanges();
        }

        public void EditarAsiento(AsientoEditarModel asientoEditar)
        {
            var asiento = this.context.Asiento.Find(asientoEditar.IdAsiento);

            if (asiento == null)
            {
                throw new ArgumentNullException("Asiento no encontrado");
            }

            asiento.IdBus = asientoEditar.IdBus;
            asiento.NumeroPiso = asientoEditar.NumeroPiso;
            asiento.NumeroAsiento = asientoEditar.NumeroAsiento;
            asiento.FechaCreacion = (DateTime)asientoEditar.FechaCreacion;

            this.context.Asiento.Update(asiento);
            this.context.SaveChanges();
        }

        public void EliminarAsiento(AsientoEliminarModel asientoEliminar)
        {
            var asientoModelEliminar = this.context.Asiento.Find(asientoEliminar.IdAsiento);
            if (asientoModelEliminar == null)
            {
                throw new ArgumentNullException("Asiento no encontrado");
            }

            this.context.Remove(asientoModelEliminar);
            this.context.SaveChanges();
        }

     

        public List<AsientoModel> GetAsientoList()
        {
            return this.context.Asiento.Select(asi => new AsientoModel()
            {
                IdAsiento = asi.IdAsiento,
                IdBus = asi.IdBus,
                NumeroPiso = asi.NumeroPiso,
                NumeroAsiento = asi.NumeroAsiento,
                FechaCreacion = asi.FechaCreacion
            }).ToList();
        }
    }
}
