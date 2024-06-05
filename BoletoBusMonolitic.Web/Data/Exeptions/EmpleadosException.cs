namespace BoletoBusMonolitic.Web.Data.Exeptions
{
    public class EmpleadosException : Exception
    {
        public EmpleadosException(string massage) : base(massage)
        {

        }

        public void Error()
        {
            throw new EmpleadosException("Empleado no encontrado");
        }
    }
}
