using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Reserva : BaseEntity
    {
        //Atributos de la entidad

        private int IdViaje;
        private int IdPasajero;
        private int AsientoReservado;
        private double MontoTotal;
        private DateTime FechaCreacion;
        public Reserva(int id, int idViaje, int idPasajero, int asientoReservado, double montoTotal, DateTime fechaCreacion) : base(id)
        {
            this.IdViaje = idViaje;
            this.IdPasajero = idPasajero;
            this.AsientoReservado = asientoReservado;
            this.MontoTotal = montoTotal;
            this.FechaCreacion = fechaCreacion;
        }
    }
}
//Angel Miguel de la Rosa