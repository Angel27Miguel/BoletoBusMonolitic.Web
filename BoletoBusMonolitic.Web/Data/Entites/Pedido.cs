using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Pedido : BaseEntity
    {
        private int IdCliente;
        private int IdMesa;
        private DateTime Fecha;
        private double Total;
        public Pedido(int id) : base(id)
        {
        }
    }
}
