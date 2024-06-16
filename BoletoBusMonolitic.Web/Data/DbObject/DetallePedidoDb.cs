using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entities;
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

            if (detallePedido == null)
            {
                throw new ArgumentNullException("Este detalle de pedido no se encuentra registrado.");
            }

            return new DetallePedidoModel
            {
                IdDetallePedido = detallePedido.IdDetallePedido,
                IdPedido = detallePedido.IdPedido,
                IdPlato = detallePedido.IdPlato,
                Cantidad = detallePedido.Cantidad,
                Subtotal = detallePedido.Subtotal
            };
        }
        public List<DetallePedidoModel> GetDetallePedidos()
        {
            return this.context.DetallePedido.Select(cdp => new DetallePedidoModel()
            {
                IdDetallePedido = cdp.IdDetallePedido,
                IdPedido = cdp.IdPedido,
                IdPlato = cdp.IdPedido,
                Cantidad = cdp.Cantidad,
                Subtotal = cdp.Subtotal
            }).ToList();
        }

        public void Eliminar(DetallePedidoEliminarModel detallePedidoEliminar)
        {
            if (detallePedidoEliminar == null)
            {
                throw new ArgumentNullException(nameof(detallePedidoEliminar));
            }

            var detallePedido = this.context.DetallePedido.Find(detallePedidoEliminar.IdDetallePedido);
            if (detallePedido == null)
            {
                throw new ArgumentException("Este detalle de pedido no se encuentra registrado.");
            }

            this.context.DetallePedido.Remove(detallePedido);
            this.context.SaveChanges();
        }

        public void Agregar(DetallePedidoAgregarModel detallePedidoAgregar)
        {
            if (detallePedidoAgregar == null)
            {
                throw new ArgumentNullException(nameof(detallePedidoAgregar));
            }

            var detallePedido = new DetallePedido
            {
                IdPedido = detallePedidoAgregar.IdPedido,
                IdPlato = detallePedidoAgregar.IdPlato,
                Cantidad = detallePedidoAgregar.Cantidad,
                Subtotal = detallePedidoAgregar.Subtotal
            };

            this.context.DetallePedido.Add(detallePedido);
            this.context.SaveChanges();
        }

        public void Actualizar(DetallePedidoActualizarModel detallePedidoActualizar)
        {
            if (detallePedidoActualizar == null)
            {
                throw new ArgumentNullException(nameof(detallePedidoActualizar));
            }

            var detallePedido = this.context.DetallePedido.Find(detallePedidoActualizar.IdDetallePedido);
            if (detallePedido == null)
            {
                throw new ArgumentException("Este detalle de pedido no se encuentra registrado.");
            }

            detallePedido.IdPedido = detallePedidoActualizar.IdPedido;
            detallePedido.IdPlato = detallePedidoActualizar.IdPlato;
            detallePedido.Cantidad = detallePedidoActualizar.Cantidad;
            detallePedido.Subtotal = detallePedidoActualizar.Subtotal;

            this.context.DetallePedido.Update(detallePedido);
            this.context.SaveChanges();
        }
    }
}
