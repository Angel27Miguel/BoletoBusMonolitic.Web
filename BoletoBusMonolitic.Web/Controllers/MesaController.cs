using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class MesaController : Controller
    {
        private readonly IMesa mesa;

        public MesaController(IMesa mesa)
        {
            this.mesa = mesa;
        }
        // GET: MesaController
        public ActionResult Index()
        {
            var mesa = this.mesa.GetMesaModel();
            return View(mesa);
        }

        // GET: MesaController/Details/5
        public ActionResult Details(int id)
        {
            var mesa = this.mesa.GetMesa(id);
            return View(mesa);
        }

        // GET: MesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MesaSaveModel mesaSave)
        {
            try
            {
                this.mesa.GuardarMesa(mesaSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaController/Edit/5
        public ActionResult Edit(int id)
        {
            var mesa = this.mesa.GetMesa(id);
            return View(mesa);
        }

        // POST: MesaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MesaUpdateModel mesaUpdate)
        {
            try
            {
                this.mesa.UpdateMesa(mesaUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesaController/Delete/5
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
