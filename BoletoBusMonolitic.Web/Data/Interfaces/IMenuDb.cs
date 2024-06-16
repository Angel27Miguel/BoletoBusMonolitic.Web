using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IMenuDb
    {
        List<MenuModel> GetMenus();
        MenuModel GetMenuModel(int idPlato);
        public void Agregar(MenuAgregarModel menuAdd);
        public void Eliminar(MenuEliminarModel menuRemove);
        public void Actualizar(MenuActualizarModel menuRemove);
    }
}
