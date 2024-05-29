using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IFactura
    {
        List<Factura> GetFacturaList();

        public void AgregarFactura();

        public void EliminarFactura();

        public void MostrarFactura();
    }
}

/*Daniel Alexander Dominguez*/