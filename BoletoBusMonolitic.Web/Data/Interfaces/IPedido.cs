using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IPedido
    {
        List<Pedido> GetPedidoList();
        public void Actualizar();
        public void Eliminar();
        public void Agregar();   
    }
}
