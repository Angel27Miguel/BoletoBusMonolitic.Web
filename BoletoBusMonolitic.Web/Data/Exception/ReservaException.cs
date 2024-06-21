namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ReservaException : Exception
    {
        public ReservaException(string massage) : base(massage)
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
