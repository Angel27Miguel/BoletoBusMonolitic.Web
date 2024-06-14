using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface ICliente
    {
        void GuardarCliente(ClienteSaveModel clienteModel);
        void EliminarCliente(ClienteDeleteModel clienteDelete);
        void ActualizarClientes(ClienteUpdateModel updateModel);
        ClienteModel GetCliente(int IdCliente);
        List<ClienteModel> GetCliente();

    }
}

/*Daniel Alexander Dominguez*/