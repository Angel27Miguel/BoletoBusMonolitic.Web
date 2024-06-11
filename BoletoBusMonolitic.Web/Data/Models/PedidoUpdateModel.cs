﻿namespace BoletoBusMonolitic.Web.Data.Models
{
    public class PedidoUpdateModel
    {
        public int PedidoUpdateModelId { get; set; }
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdMesa { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
    }
}