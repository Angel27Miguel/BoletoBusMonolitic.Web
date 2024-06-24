
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class RutaDb : IRuta
    {

        private readonly BoletoBusContext context;
        
        public RutaDb(BoletoBusContext context)
        {
            this.context = context; 
        }

        public void GuardarRuta(RutaGuardarModel rutaGuardar)
        {
            Ruta ruta = new Ruta() { 

                Origen = rutaGuardar.Origen,
                Destino = rutaGuardar.Destino,
                FechaCreacion = rutaGuardar.FechaCreacion,

            
            };

            this.context.Ruta.Add(ruta);
            this.context.SaveChanges();


        }

        public void EditarRuta(RutaEditarModel rutaEditar)
        {
            var ruta = this.context.Ruta.Find(rutaEditar.IdRuta);

            if (ruta == null)
            {
                throw new ArgumentNullException("Ruta no encontarda");   
            }

            ruta.IdRuta = rutaEditar.IdRuta;
            ruta.Origen = rutaEditar.Origen;
            ruta.Destino = rutaEditar.Destino;
            ruta.FechaCreacion = (DateTime)rutaEditar.FechaCreacion;

            this.context.Ruta.Update(ruta);
            this.context.SaveChanges();


          
        }

        public void EliminarRuta(RutaEliminarModel rutaEliminar)
        {
            var rutaModelEliminar = this.context.Ruta.Find(rutaEliminar.IdRuta);
            if (rutaModelEliminar == null)
            { 
                    throw new ArgumentNullException("Ruta no encontrada");
            }
            rutaModelEliminar.IdRuta = rutaEliminar.IdRuta;
            this.context.Remove(rutaModelEliminar);
            this.context.SaveChanges();
        }

        public RutaModel GetRutaModel(int idRuta)
        {
            var ruta = this.context.Ruta.Find(idRuta);

            if (ruta == null) 
            {
                throw new ArgumentNullException("Esta ruta no se encuentra");
            }

            return new RutaModel
            { 
                IdRuta = ruta.IdRuta,
                Origen = ruta.Origen,
                Destino = ruta.Destino,
                FechaCreacion = ruta.FechaCreacion,

            };
        }

        public List<RutaModel> GetRutaList()
        {
            return this.context.Ruta.Select(rut => new RutaModel()
            { 
                IdRuta = rut.IdRuta,
                Origen = rut.Origen,
                Destino = rut.Destino,  
                FechaCreacion = rut.FechaCreacion,
            
            
            
            }).ToList();

        }
    }
}
