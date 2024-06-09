using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Daos
{
    public class DetallePedidoDb : IDetallePedidoDb
    {
        private readonly BoletoBusContext context;

        public DetallePedidoDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public DetallePedidoModel GetDetallePedidoModel(int idDetallePedido)
        {

            var detallePedido = this.context.DetallePedido.Find(idDetallePedido);

            ArgumentNullException.ThrowIfNull(detallePedido, "Este pedido no se encuentra registrado.");


            DetallePedidoModel detallePedidoModel = new DetallePedidoModel()
            {
                IdDetallePedido = detallePedido.IdDetallePedido,
                IdPedido = detallePedido.IdPedido,
                IdPlato = detallePedido.IdPlato,
                Cantidad = detallePedido.Cantidad,
                Subtotal = detallePedido.Subtotal,
            };

            return detallePedidoModel;
        }

        public void Mostrar(DetallePedidoReadModel detallePedidoRead)
        {
            var detallePedido = this.context.DetallePedido.Find(detallePedidoRead.IdDetallePedido);
            if (detallePedido == null)
            {
                throw new ArgumentException("El detalle de pedido no se encuentra registrado.");
            }
        }



        public List<DetallePedidoModel> GetDetallePedidoList()
        {
            return this.context.DetallePedido.Select(cdp => new DetallePedidoModel()
            {
                IdDetallePedido = cdp.IdDetallePedido,
                IdPedido = cdp.IdPedido,
                IdPlato = cdp.IdPedido,
                Cantidad = cdp.Cantidad,
                Subtotal = cdp.Subtotal,
            }).ToList();
        }
    }
}
