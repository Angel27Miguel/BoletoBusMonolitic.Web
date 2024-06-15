using BoletoBusMonolitic.Web.Data.DbObject;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using BoletoBusMonolitic.Web.Date.Daos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IReserva reservaDb;

        public ReservaController(IReserva reservaDb)
        {
            this.reservaDb = reservaDb;
        }
        // GET: ReservaController
        public ActionResult Index()
        {
            var reserva = this.reservaDb.GetReservaList();
            return View(reserva);
        }

        // GET: ReservaController/Details/5
        public ActionResult Details(int id)
        {
            var reserva = this.reservaDb.GetReservaModel(id);
            return View(reserva);
        }

        // GET: ReservaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaGuardarModel reservaGuardar)
        {
            try
            {
                reservaGuardar.FechaCreacion = DateTime.Now;
                this.reservaDb.GuardarReserva(reservaGuardar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaController/Edit/5
        public ActionResult Edit(int id)
        {
            var reserva = this.reservaDb.GetReservaModel(id);
            return View(reserva);
        }

        // POST: ReservaController/Edit/5
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

        // GET: ReservaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservaController/Delete/5
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
