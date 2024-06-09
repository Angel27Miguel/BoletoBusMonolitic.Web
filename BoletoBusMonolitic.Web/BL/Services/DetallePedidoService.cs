

using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Daos;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.BL.Services
{
    public class DetallePedidoService : IDetallePedidoService
    {
        private readonly IDetallePedidoDb detallePedidoDb;

        public DetallePedidoService(IDetallePedidoDb departmentDb)
        {
            this.detallePedidoDb = departmentDb;
        }
        public List<DetallePedidoModel> GetDetallePedidos()
        {
            return this.detallePedidoDb.GetDetallePedidos();
        }
    }

  
}