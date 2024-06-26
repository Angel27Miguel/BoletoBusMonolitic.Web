
using BoletoBusMonolitic.Web.Data.Models;
namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface ICliente
    {
        ClienteModel GetCliente(int IdCliente);
        List<ClienteModel> GetClienteModel();
        void GuardarCliente(ClienteSaveModel clienteModel);
        void EliminarCliente();
        void ActualizarClientes(ClienteUpdateModel updateModel);

    }
}

/*Daniel Alexander Dominguez*/