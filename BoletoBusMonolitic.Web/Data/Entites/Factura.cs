using System;
using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data
{
    public class Factura:BaseEntity
    {
        private int Numerodefactura;
        private string? Cliente;
        private DateTime Fechadevencimiento;

        public Factura(int id, int Numerodefactura, string? Cliente, DateTime Fechadevencimiento) : base(id)
        {
        this.Numerodefactura = Numerodefactura;
        this.Cliente = Cliente;
        this.Fechadevencimiento = Fechadevencimiento;
        }
    }

}

/*Daniel Alexander Dominguez*/
