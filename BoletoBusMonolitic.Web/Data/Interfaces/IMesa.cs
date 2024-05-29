using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IMesa
    {
        List<Mesa> GetMesaList();

        public void AgregarMesa();

        public void EliminarMesa();

        public void MostrarMesa();
    }
}

/*Daniel Alexander Dominguez*/