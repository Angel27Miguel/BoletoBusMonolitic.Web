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
       
    }
}
//Angel Miguel de la Rosa