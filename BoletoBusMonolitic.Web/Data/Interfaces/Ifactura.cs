

using BoletoBusMonolitic.Web.Data.Models;
using System.Collections.Generic;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IFactura
    {
        FacturaModel GetFactura(int IDFactura);
        List<FacturaModel> GetFacturaModel();
        void GuardarFactura(FacturaSaveModel facturaSave);
        void EliminarFactura();
        void ActualizarFactura(FacturaUpdateModel facturaUpdate);
    }
}

/*Daniel Alexander Dominguez*/