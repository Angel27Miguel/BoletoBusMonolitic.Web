using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Daos
{
    public class MenuDb : IMenuDb
    {
        private readonly BoletoBusContext context;

        public MenuDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public void Actualizar(MenuActualizarModel menuUpdate)
        {
            var menu = this.context.Menu.Find(menuUpdate.IdPlato);
            if (menu == null)
            {
                throw new ArgumentException("El menú no se encuentra registrado.");
            }

            menu.Categoria = menuUpdate.Categoria;
            menu.Descripcion = menuUpdate.Descripcion;
            menu.Nombre = menuUpdate.Nombre;
            menu.Precio = menuUpdate.Precio;

            this.context.Menu.Update(menu);
            this.context.SaveChanges();
        }

        public void Agregar(MenuAgregarModel menuAdd)
        {
            Menu menu = new Menu()
            {
                Categoria = menuAdd.Categoria,
                Descripcion = menuAdd.Descripcion,
                Nombre = menuAdd.Nombre,
                Precio = menuAdd.Precio
            };

            this.context.Menu.Add(menu);
            this.context.SaveChanges();
        }

        public void Eliminar(MenuEliminarModel menuRemove)
        {
            var menu = this.context.Menu.Find(menuRemove.IdPlato);
            if (menu == null)
            {
                throw new ArgumentException("El menú no se encuentra registrado.");
            }

            this.context.Menu.Remove(menu);
            this.context.SaveChanges();
        }

        public MenuModel GetMenuModel(int idPlato)
        {

            var menu = this.context.Menu.Find(idPlato);

            ArgumentNullException.ThrowIfNull(menu, "Este menu no se encuentra registrado.");


            MenuModel menuModel = new MenuModel()
            {
                IdPlato = idPlato,
                Categoria = menu.Categoria,
                Descripcion = menu.Descripcion,
                Nombre = menu.Nombre,
                Precio = menu.Precio,
            };

            return menuModel;
        }

        public List<MenuModel> GetMenus()
        {
            return this.context.Menu.Select(cm => new MenuModel()
            {
                IdPlato = cm.IdPlato,
                Categoria = cm.Categoria,
                Descripcion = cm.Descripcion,
                Nombre = cm.Nombre,
                Precio = cm.Precio,
            }).ToList();
        }
    }
}
