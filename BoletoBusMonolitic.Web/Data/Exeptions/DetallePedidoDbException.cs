using System;

namespace BoletoBusMonolitic.Web.Data.Exceptions
{
    public class DetallePedidoDbException : Exception
    {
        public DetallePedidoDbException(string message) : base(message)
        {
            LogError(message);
            SendError(message);
        }

        private void LogError(string message)
        {
            Console.WriteLine($"Error: {message}");
        }

        private void SendError(string message)
        {
            Console.WriteLine($"Enviando correo con error: {message}");
        }
    }
}