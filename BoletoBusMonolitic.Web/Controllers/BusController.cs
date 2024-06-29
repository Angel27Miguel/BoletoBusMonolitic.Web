using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class BusController : Controller
    {
        private readonly IBus busdb;
        public BusController(IBus busdb)
        {
            this.busdb = busdb;
            
        }
        // GET: BusController
        public ActionResult Index()
        {
            var bus = this.busdb.GetBusList();
            return View(bus);
        }

        // GET: BusController/Details/5
        public ActionResult Details(int id)
        {
            var bus = this.busdb.GetBusModel(id);
            return View(bus);
        }

        // GET: BusController/Create
        public ActionResult Create()
        {
            
                return View();
            
        }

        // POST: BusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BusGuardarModel busGuardar)
        {
            try
            {
                busGuardar.FechaCreacion = DateTime.Now;
                this.busdb.GuardarBus(busGuardar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Edit/5
        public ActionResult Edit(int id)
        {
            var bus = this.busdb.GetBusModel(id);
            return View(bus);
        }

        // POST: BusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BusEditarModel busEditar)
        {
            try
            {
                busEditar.FechaCreacion = DateTime.Now;
                this.busdb.EditarBus(busEditar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusController/Delete/5
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
