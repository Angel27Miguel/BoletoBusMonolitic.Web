using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Reserva : BaseEntity
    {
        //Atributos de la entidad

        private int IdViaje { get; set; }
        private int IdPasajero { get; set; }
        private int AsientoReservado { get; set; }
        private double MontoTotal { get; set; }
        private DateTime FechaCreacion { get; set; }

    }
}
//Angel Miguel de la Rosa