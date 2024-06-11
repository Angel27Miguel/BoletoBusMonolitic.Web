using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuDb menuDb;

        public MenuService(IMenuDb menuDb)
        {
            this.menuDb = menuDb;
        }
        public List<MenuModel> GetMenus()
        {
            return this.menuDb.GetMenus();
        }
    }
}
