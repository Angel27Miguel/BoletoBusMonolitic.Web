using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IPedidoDb
    {
        List<PedidoModel> GetPedidos();
        PedidoModel GetPedidoModel(int idPedido);
        public void Eliminar(PedidoEliminarModel pedidoEliminar);
        public void Agregar(PedidoAgregarModel pedidoAgregar);
        public void Actualizar(PedidoActualizarModel pedidoActualizar  );
    }
}
//Ismael Garcia