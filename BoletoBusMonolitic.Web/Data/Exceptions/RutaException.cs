namespace BoletoBusMonolitic.Web.Data.Exceptions
{
    public class RutaException : Exception
    {
        public RutaException(string message) : base(message)
        {

        }

        public void Error()
        {
            throw new NotImplementedException("Ruta no encontrada");
        }
    }
}
