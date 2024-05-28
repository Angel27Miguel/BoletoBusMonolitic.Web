using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IDetallePedido
    {
        List<DetallePedido> GetDetallePedidoList();
        public void Mostrar();

        public void Actualizar();
        public void Agregar();
        public void Eliminar();


    }
   
}
