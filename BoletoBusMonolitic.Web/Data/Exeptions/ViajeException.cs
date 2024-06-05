namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class ViajeException : Exception
    {

        public ViajeException(string massage) :base (massage) 
        { 
        
        }

        public void ErrorMessage()
        {
           throw new ViajeException ("Viaje no encontrado");
        }

      
    }
}
