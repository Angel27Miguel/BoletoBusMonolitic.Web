namespace BoletoBusMonolitic.Web.Data.Exceptions
{
    public class AsientoException : Exception
    {
        public AsientoException(string message) : base(message)
        {

        }

        public void Error()
        {
            throw new NotImplementedException("Asiento no encontrado");
        }
    }
}
