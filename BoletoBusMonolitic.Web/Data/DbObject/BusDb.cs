using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class BusDb : IBus
    {
        private readonly BoletoBusContext context;
        private readonly RutaException exception;

        public BusDb(BoletoBusContext context, RutaException exception)
        {
            this.context = context;
            this.exception = exception;
        }

        public void AgregarBus(BusGuardarModel busGuardar)
        {
            throw new NotImplementedException();
        }

        public void EditarBus(BusEditarModel busEditar)
        {
            throw new NotImplementedException();
        }

        public void EliminarBus(BusEliminarModel busEliminar)
        {
            throw new NotImplementedException();
        }

        public BusModel GetBusModel(int idBus)
        {
            throw new NotImplementedException();
        }

        public List<BusModel> GetBusModels()
        {
            throw new NotImplementedException();
        }
    }
}
