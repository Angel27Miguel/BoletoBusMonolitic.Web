using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
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
            return View(viaje);
            
        }

        // GET: ViajeController1/Details/5
        public ActionResult Details(int id)
        {
            var viaje = this.viajeDb.GetViaje(id);
            return View(viaje);
        }

        // GET: ViajeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViajeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ViajeGuardarModel viajeGuardar)
        {
            try
            {
                this.viajeDb.GuardarViaje(viajeGuardar);
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
            var viaje = this.viajeDb.GetViaje(id);
            return View(viaje);
        }

        // POST: ViajeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ViajeEditarModel viajeEditar)
        {
            try
            {
                this.viajeDb.EditarViaje(viajeEditar);
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
