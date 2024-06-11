using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Reserva : BaseEntity
    {
        //Atributos de la entidad

        public int IdReserva { get; set; }
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public int AsientoReservado { get; set; }
        public double MontoTotal { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
//Angel Miguel de la Rosa