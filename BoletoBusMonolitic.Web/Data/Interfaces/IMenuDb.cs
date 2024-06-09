using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IMenuDb
    {
        List<MenuModel> GetMenuList();
        MenuModel GetMenuModel(int idPlato);
        public void Agregar(MenuAddModel menuAdd);
        public void Actualizar(MenuUpdateModel menuUpdate);
        public void Eliminar(MenuRemoveModel menuRemove);
    }
}
