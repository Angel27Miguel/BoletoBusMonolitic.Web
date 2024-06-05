namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ReservaEditarModel
    {
        public int IdReserva { get; set; }
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public string? Psajero { get; set; }
        public int AsientoReservado { get; set; }
        public double MontoTotal { get; set; }
        public DateTime FechaEdicion { get; set; }
    }
}
//Angel Miguel de la Rosa