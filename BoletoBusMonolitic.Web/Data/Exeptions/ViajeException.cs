﻿namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ViajeException : Exception
    {

        public ViajeException(string massage) :base (massage) 
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