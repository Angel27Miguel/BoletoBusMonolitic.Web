using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Bus : BaseEntity
    {
        //atributos
        private int idAsiento;
        private int numeroPlaca;
        private string nombre;
        private string capacidadPiso1;
        private string capacidadPiso2;
        private string capacidadtTotal;
        private Boolean disponible;
        private DateTime fechaCreacion;

        public Bus(int id) : base(id)
        {
        }
    }
}
