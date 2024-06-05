namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ReservaDetalleModel
    {
        public int IdReservaDetalle { get; set; }
        public int IdReserva {  get; set; }
        public int IdAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
//Angel Miguel de la Rosa