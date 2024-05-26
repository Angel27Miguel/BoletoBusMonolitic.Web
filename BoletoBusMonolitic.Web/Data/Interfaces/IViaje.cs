using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IViajeDb
    {
        List<Viaje> GetViajeList();
    }
}
