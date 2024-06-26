using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class FacturaController : Controller

    {
        private readonly IFactura factura;

        public FacturaController(IFactura factura)
        {
            this.factura = factura;
        }
        // GET: FacturaController
        public ActionResult Index()
        {
            var factura = this.factura.GetFacturaModel();
            return View(factura);
        }

        // GET: FacturaController/Details/5
        public ActionResult Details(int id)
        {
            var factura = this.factura.GetFactura(id);
            return View(factura);
        }

        // GET: FacturaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacturaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FacturaSaveModel facturaSave)
        {
            try
            {
                this.factura.GuardarFactura(facturaSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FacturaController/Edit/5
        public ActionResult Edit(int id)
        {
            var factura = this.factura.GetFactura(id);
            return View(factura);
        }

        // POST: FacturaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FacturaUpdateModel facturaUpdate)
        {
            try
            {
                this.factura.ActualizarFactura(facturaUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FacturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FacturaController/Delete/5
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
