using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IDetallePedidoDb
    {
        DetallePedidoModel GetDetallePedidoModel(int idDetallePedido);
        List<DetallePedidoModel> GetDetallePedidos();
        void Eliminar(DetallePedidoEliminarModel detallePedidoEliminar);
        void Agregar(DetallePedidoAgregarModel detallePedidoAgregar);
        void Actualizar(DetallePedidoActualizarModel detallePedidoActualizar);
    }
   
}
