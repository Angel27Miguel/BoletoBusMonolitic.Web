using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Exeptions;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class RutaDb : IRuta
    {

        private readonly BoletoBusContext context;
        private readonly RutaException exception;

        public void AgregarRuta(RutaAgregarModel rutaAgregar)
        {
            throw new NotImplementedException();
        }

        public void EditarRuta(RutaEditarModel rutaEditar)
        {
            var RutaEdita = this.context.Ruta.Find();
            if (RutaEdita == null)
            {

            }

            RutaEdita.Nombre = RutaEditar.Nombre;
            RutaEdita.Cargo = Editar.Cargo;

            this.context.Empleado.Update(EmpleadoEdita);
            this.context.SaveChanges();
        }

        public void EliminarRuta(RutaEliminarModel rutaEliminar)
        {
            throw new NotImplementedException();
        }

        public RutaModel GetRutaModel(int idRuta)
        {
            throw new NotImplementedException();
        }

        public List<RutaModel> GetRutaModels()
        {
            throw new NotImplementedException();
        }
    }
}
