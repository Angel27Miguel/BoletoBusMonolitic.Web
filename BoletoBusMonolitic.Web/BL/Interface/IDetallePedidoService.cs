using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IDetallePedidoService
    {
        List<DetallePedidoModel> GetDetallePedidos();
    }
}

