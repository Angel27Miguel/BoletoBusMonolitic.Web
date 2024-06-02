using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class DetallePedido : BaseEntity
    {
        //atributos
        private int IdDetallePedido;
        private int IdPedido;
        private int IdPlato;
        private int Cantidad;
        private double Subtotal;

        public DetallePedido(int Id, int IdDetallePedido, int IdPedido, int IdPlato, int Cantidad, double Subtotal) : base(Id)
        {
            this.IdDetallePedido = IdDetallePedido;
            this.IdPedido = IdPedido;
            this.IdPlato = IdPlato;
            this.Cantidad = Cantidad;
            this.Subtotal = Subtotal;
        }
    }
}
//Ismael Garcia