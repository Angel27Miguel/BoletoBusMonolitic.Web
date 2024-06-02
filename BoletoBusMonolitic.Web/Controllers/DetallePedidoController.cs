using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class DetallePedidoController : Controller
    {
        private BoletoBusContext context;

        public DetallePedidoController()
        {
            this.context = new BoletoBusContext();
            
        }
        // GET: DetallePedidoController

        public ActionResult Index()
        {
            var Pedido = this.context. Pedido.ToList();
            return View();
        }

        // GET: DetallePedidoController/Details/5
        public ActionResult Details(int id)
        {
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
