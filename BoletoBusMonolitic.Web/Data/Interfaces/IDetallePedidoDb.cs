using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IDetallePedidoDb
    {
        DetallePedidoModel GetDetallePedidoModel(int idDetallePedido);
        List<DetallePedidoModel> GetDetallePedidos();
        void Mostrar(DetallePedidoReadModel detallePedidoRead);

    }
   
}
