namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class EmpleadosException : Exception
    {
        public EmpleadosException(string massage) : base(massage)
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
