using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Pedido : BaseEntity
    {
        private int IdCliente;
        private int IdMesa;
        private DateTime Fecha;
        private double Total;
        public Pedido(int id, int IdCliente, int IdMesa, DateTime Fecha, double Total) : base(id)
        {
            this.IdCliente = IdCliente;
            this.IdMesa = IdMesa;   
            this.Fecha = Fecha;
            this.Total = Total;
        }
    }
}
