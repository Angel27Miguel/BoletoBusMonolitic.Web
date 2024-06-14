using System;
using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data
{
    public class Factura:BaseEntity
    {
        public int IDFactura;
        public int IDPedido;
        public int Total;
        public DateTime Fecha;

        public Factura() { }

        public Factura(int id, int IDFactura, int IDPedido, int Total, DateTime Fecha) : base()
        {
            Id = id;
            this.IDFactura = IDFactura;
            this.IDPedido = IDPedido;
            this.Total = Total;
            this.Fecha = Fecha;
        }

        public int Id { get; }
        public int IdFactura { get; internal set; }
    }

}

/*Daniel Alexander Dominguez*/
