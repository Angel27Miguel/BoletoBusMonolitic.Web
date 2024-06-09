using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Date.Daos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class ViajeController : Controller
    {

       private readonly IViajeDb viajeDb;

        public ViajeController(IViajeDb viajeDb)
        {
            this.viajeDb = viajeDb;
        }
        // GET: ViajeController1
        public ActionResult Index()
        {
            var viaje = this.viajeDb.GetViajeModels();
            return View(viajeDb);
            
        }

        // GET: ViajeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViajeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViajeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ViajeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViajeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ViajeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViajeController1/Delete/5
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
