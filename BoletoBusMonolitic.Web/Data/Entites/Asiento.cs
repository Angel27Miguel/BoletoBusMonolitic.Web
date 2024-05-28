using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Asiento : BaseEntity
    {
        private int idBus;
        private int numeroPiso;
        private int numeroAsiento;
        private DateTime fechaCreacion;
        public Asiento(int id) : base(id)
        {
        }
    }
}
