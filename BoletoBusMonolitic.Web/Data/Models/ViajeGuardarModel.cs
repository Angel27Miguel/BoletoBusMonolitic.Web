namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ViajeGuardarModel
    {
        public int IdBus { get; set; }
        public string? Bus { get; set; }
        public int IdRuta { get; set; }
        public int IdPasajero { get; set; }
        public string? Pasajero { get; set; }
        public string? Ruta { get; set; }
        public DateTime FechaSalida { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public double Precio { get; set; }
    }
}
