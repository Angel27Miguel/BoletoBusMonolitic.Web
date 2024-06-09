using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IDetallePedidoDb
    {
        DetallePedidoModel GetDetallePedidoModel(int idDetallePedido);
        List<DetallePedidoModel> GetDetallePedidoList();
        void Mostrar(DetallePedidoReadModel detallePedidoRead);

    }
   
}
