using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoDb pedidoDb;

        public PedidoService(IPedidoDb pedidoDb)
        {
            this.pedidoDb = pedidoDb;
        }
        public List<PedidoModel> GetPedidos()
        {
            return this.pedidoDb.GetPedidos();
        }
    }
}
