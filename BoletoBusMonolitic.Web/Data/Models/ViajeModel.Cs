using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ViajeModel
    {
        public int IdViaje { get; set; }
        public int IdBus { get; set; }
        public int IdRuta { get; set; }
        public int IdPasajero { get; set; }
        public DateTime FechaSalida { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public double Precio { get; set; }
        public int TotalAsiento { get; set; }
        public int AsientosDisponibles { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}
//Angel Miguel de la Rosa