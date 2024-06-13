using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ViajeEditarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdViaje { get; set; }
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
        public int TotalAsiento { get; set; }
        public int AsientosDisponibles { get; set; }
        public DateTime FechaEditado { get; set; }
        
    }
}
