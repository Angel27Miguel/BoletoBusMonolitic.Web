using BoletoBusMonolitic.Web.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class MesaController : Controller
    {
        private readonly ICliente cliente;

        public MesaController(ICliente cliente)
        {
            this.cliente = cliente;
        }
        // GET: MesaController
        public ActionResult Index()
        {
            var cliente = this.cliente.GetClienteList();
            return View(cliente);
        }

        // GET: MesaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesaController/Create
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

        // GET: MesaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MesaController/Edit/5
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
