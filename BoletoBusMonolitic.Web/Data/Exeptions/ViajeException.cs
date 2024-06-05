namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ViajeException : Exception
    {
        public ViajeException(string massage) :base (massage) 
        { 
        
        }

        public void Error (string message)
        {
            message = "Viaje no encontrado";
        }

        internal void Error()
        {
            throw new NotImplementedException();
        }
    }
}
