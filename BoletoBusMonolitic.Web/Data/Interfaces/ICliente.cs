using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface ICliente
    {
        List<Cliente> GetClienteList();

        public void AgregarCliente();

        public void EliminarCliente();

        public void MostrarClientes();
    }
}

/*Daniel Alexander Dominguez*/