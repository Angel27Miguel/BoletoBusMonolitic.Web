using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;

namespace BoletoBusMonolitic.Web.Data.Daos
{
    public class DetallePedidoDb : IDetallePedido
    {
        private readonly BoletoBusContext context;

        public DetallePedidoDb(BoletoBusContext context)
        {
            this.context = context;
        }
        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public List<DetallePedido> GetDetallePedidoList()
        {
            throw new NotImplementedException();
        }

        public void Mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
