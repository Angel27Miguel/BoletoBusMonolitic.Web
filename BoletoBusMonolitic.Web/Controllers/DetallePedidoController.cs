using BoletoBusMonolitic.Web.BL.Exeptions;
using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Daos;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
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

        // GET: DetallePedidoController/Details
        public ActionResult Details(int id)
        {
            var detallePedido = this.detallePedidoService.GetDetallePedidoModel(id);
            return View();
        }


        // GET: DetallePedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetallePedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DetallePedidoAgregarModel detallePedidoAgregar)
        {
            try
            {
                this.detallePedidoService.Agregar(detallePedidoAgregar);
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
            var detallePedido = this.detallePedidoService.GetDetallePedidoModel(id);
            return View();
        }

        // POST: DetallePedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DetallePedidoActualizarModel detallePedidoActualizar)
        {
            try
            {
                this.detallePedidoService.Equals(detallePedidoActualizar);
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
