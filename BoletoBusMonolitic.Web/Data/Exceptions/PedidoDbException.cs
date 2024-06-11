using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace BoletoBusMonolitic.Web.Data.Exceptions
{
    public class PedidoDbException : Exception
    {
        public PedidoDbException(string message) : base(message)
        {
            LogError(message);
            SendError(message);
        }

        private void LogError(string message)
        {
            string logFilePath = "error_log.txt";
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        private void SendError(string message)
        {
            Console.WriteLine($"Enviando correo con error: {message}");
        }
    }
}