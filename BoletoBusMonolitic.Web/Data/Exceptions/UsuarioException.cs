namespace BoletoBusMonolitic.Web.Data.Exceptions
{
    public class UsuarioException : Exception
    {
        public UsuarioException(string message) : base(message){
        
        }

        public void Error()
        { 
            throw new NotImplementedException("Usuario no encontrado");
        }
    
    }
}
