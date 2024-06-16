using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuDb menuService;

        public MenuController(IMenuDb menuDb)
        {
            this.menuService = menuDb;
        }
        // GET: MenuController
        public ActionResult Index()
        {
            var Menu = this.menuService.GetMenus();
            return View(Menu);
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            var menu = this.menuService.GetMenuModel(id);
            return View(menu);
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuAgregarModel menuAdd)
        {
            try
            {
                this.menuService.Agregar(menuAdd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var menu = this.menuService.GetMenuModel(id);
            return View();
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MenuActualizarModel menuActualizar)
        {
            try
            {
                this.menuService.Actualizar(menuActualizar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
