﻿using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public class Pedido : BaseEntity
    {
        public int PedidoId { get; set; }
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdMesa { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
    }
}