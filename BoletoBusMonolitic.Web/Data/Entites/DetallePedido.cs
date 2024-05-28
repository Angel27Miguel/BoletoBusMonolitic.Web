using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class DetallePedido : BaseEntity
    {
        private int IdPedido;
        private int IdPlato;
        private int Cantidad;
        private double Subtotal;

        public DetallePedido(int id, int IdPedido, int IdPlato, int Cantidad, double Subtotal) : base(id)
        {
            this.IdPedido = IdPedido;
            this.IdPlato = IdPlato;
            this.Cantidad = Cantidad;
            this.Subtotal = Subtotal;
            
        }
    }
}
