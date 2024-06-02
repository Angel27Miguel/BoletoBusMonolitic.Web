using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Pedido : BaseEntity
    {
        //atributos
        private int IdPedido;
        private int IdCliente;
        private int IdMesa;
        private DateTime Fecha;
        private double Total;

        public Pedido(int Id, int IdPedido, int IdCliente, int IdMesa, DateTime Fecha, double Total) : base(Id)
        {
            this.IdPedido = IdPedido;
            this.IdCliente = IdCliente;
            this.IdMesa = IdMesa;   
            this.Fecha = Fecha;     
            this.Total = Total;
        }
    }
}
