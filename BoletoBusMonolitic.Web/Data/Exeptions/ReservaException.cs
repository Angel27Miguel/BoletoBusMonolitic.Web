namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ReservaException : Exception
    {
        public ReservaException(string massage) : base(massage)
        {

        }

        public void Error()
        {
            throw new ReservaException("Rreserva no encontrado");
        }
    }
}
