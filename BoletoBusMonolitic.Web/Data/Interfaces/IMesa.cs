using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IMesa
    {
        Mesa GetMesa(int IDMesa);
        List<Mesa> GetMesaList();

        public void GuardarMesa(MesaSaveModel mesaSave);

        public void EliminarMesa(MesaDeleteModel mesaDelete);

        public void UpdateMesa(MesaUpdateModel mesaUpdate);
    }
}

/*Daniel Alexander Dominguez*/