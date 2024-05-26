using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class DetallePedido : BaseEntity
    {
        private int IdPedido;
        private int IdPlato;
        private int Cantidad;
        private double Subtotal;

        public DetallePedido(int idDetallePedido) : base(idDetallePedido)
        {
            
        }
    }
}
