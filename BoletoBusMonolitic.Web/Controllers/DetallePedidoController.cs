using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class DetallePedidoController : Controller
    {
        private readonly IDetallePedidoDb detallePedidoService;

        public DetallePedidoController(IDetallePedidoDb detallePedidoDb)
        {
            this.detallePedidoService = detallePedidoDb;
        }
        // GET: DetallePedidoController

        public ActionResult Index()
        {
            var DetallePedido = this.detallePedidoService.GetDetallePedidos();
            return View(DetallePedido);
        }

        // GET: DetallePedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetallePedidoController/Create
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

        // GET: DetallePedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DetallePedidoController/Edit/5
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

        // GET: DetallePedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetallePedidoController/Delete/5
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
