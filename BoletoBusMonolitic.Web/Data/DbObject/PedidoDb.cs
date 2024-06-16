using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Daos
{
    public class PedidoDb : IPedidoDb
    {
        private readonly BoletoBusContext context;

        public PedidoDb(BoletoBusContext context)
        {
            this.context = context;
        }
        public void Actualizar(PedidoActualizarModel pedidoUpdate)
        {
            var pedido = this.context.Pedido.Find(pedidoUpdate.IdPedido);
            if (pedido == null)
            {
                throw new ArgumentException("El pedido no se encuentra registrado.");
            }

            pedido.IdCliente = pedidoUpdate.IdCliente;
            pedido.IdMesa = pedidoUpdate.IdMesa;
            pedido.Fecha = pedidoUpdate.Fecha;
            pedido.Total = pedidoUpdate.Total;

            this.context.Pedido.Update(pedido);
            this.context.SaveChanges();
        }

        public void Agregar(PedidoAgregarModel pedidoAdd)
        {
            Pedido pedido = new Pedido()
            {
                IdCliente = pedidoAdd.IdCliente,
                IdMesa = pedidoAdd.IdMesa,
                Fecha = pedidoAdd.Fecha,
                Total = pedidoAdd.Total
            };

            this.context.Pedido.Add(pedido);
            this.context.SaveChanges();
        }

        public void Eliminar(PedidoEliminarModel pedidoRemove)
        {
            var pedido = this.context.Pedido.Find(pedidoRemove.IdPedido);
            if (pedido == null)
            {
                throw new ArgumentException("El pedido no se encuentra registrado.");
            }

            this.context.Pedido.Remove(pedido);
            this.context.SaveChanges();
        }

        public PedidoModel GetPedidoModel(int idPedido)
        {

            var pedido = this.context.Pedido.Find(idPedido);

            ArgumentNullException.ThrowIfNull(pedido, "Este pedido no se encuentra registrado.");


            PedidoModel pedidoModel = new PedidoModel()
            {
                IdPedido = pedido.IdPedido,
                IdCliente = pedido.IdCliente,
                IdMesa = pedido.IdMesa,
                Fecha = pedido.Fecha,
                Total = pedido.Total,
            };

            return pedidoModel;
        }

        public List<PedidoModel> GetPedidos()
        {
            return this.context.Pedido.Select(cp => new PedidoModel()
            {
                IdPedido = cp.IdPedido,
                IdCliente = cp.IdCliente,
                IdMesa = cp.IdMesa,
                Fecha = cp.Fecha,
                Total = cp.Total,
            }).ToList();
        }
    }
}
