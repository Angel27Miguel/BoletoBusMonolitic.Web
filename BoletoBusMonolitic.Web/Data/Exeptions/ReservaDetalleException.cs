namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ReservaDetalleException : Exception
    {
        public ReservaDetalleException(string massage) : base(massage)
        {

        }

		private void LogError(string message)
		{
		}

		private void SendError(string message)
		{
		}
	}
}
