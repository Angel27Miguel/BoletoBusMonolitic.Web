using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IFactura
    {
        public interface IFacturaRepository
        {
            FacturaModel GetFactura(int IDFactura);

            List<FacturaModel> GetFacturas();

            void GuardarFactura(FacturaModel facturaModel);

            void EliminarFactura(int IDFactura);

            void ActualizarFactura(FacturaModel facturaModel);
        }
    }
    }

/*Daniel Alexander Dominguez*/