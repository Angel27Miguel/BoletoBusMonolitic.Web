using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IPedidoDb
    {
        List<PedidoModel> GetPedidos();
        PedidoModel GetPedidoModel(int idPedido);
        public void Actualizar(PedidoUpdateModel pedidoUpdate);
        public void Eliminar(PedidoRemoveModel pedidoRemove);
        public void Agregar(PedidoAddModel pedidoAdd);   
    }
}
//Ismael Garcia