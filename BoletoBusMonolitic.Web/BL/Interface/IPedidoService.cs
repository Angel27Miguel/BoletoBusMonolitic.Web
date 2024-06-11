using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IPedidoService
    {
        List<PedidoModel> GetPedidos();
    }
}
