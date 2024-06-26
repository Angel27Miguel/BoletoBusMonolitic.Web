
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IMesa
    {
        MesaModel GetMesa(int IDMesa);

        List<MesaModel> GetMesaModel();

        public void GuardarMesa(MesaSaveModel mesaSave);

        public void EliminarMesa(MesaDeleteModel mesaDelete);

        public void UpdateMesa(MesaUpdateModel mesaUpdate);
    }
}

/*Daniel Alexander Dominguez*/