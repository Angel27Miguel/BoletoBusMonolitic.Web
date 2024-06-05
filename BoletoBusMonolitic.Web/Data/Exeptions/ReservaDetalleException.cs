namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ReservaDetalleException : Exception
    {
        public ReservaDetalleException(string massage) : base(massage)
        {

        }

        public void Error()
        {
            throw new ReservaDetalleException("Detalle de reserva no encontrado");
        }
    }
}
