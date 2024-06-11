namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class BusException : Exception
    {

        public BusException(string message) : base(message)
        {

        }

        public void Error()
        {
            throw new NotImplementedException("Bus no encontrado");
        }
    }
}
