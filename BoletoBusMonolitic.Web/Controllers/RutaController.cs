using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class RutaController : Controller
    {
        private readonly IRuta rutadb;
        public RutaController(IRuta rutadb) 
        {
            this.rutadb = rutadb;
        } 
        // GET: RutaController
        public ActionResult Index()
        {
            var ruta = this.rutadb.GetRutaList();
            return View(ruta);
        }

        // GET: RutaController/Details/5
        public ActionResult Details(int id)
        {
            var ruta = this.rutadb.GetRutaList();
            return View(ruta);
        }

        // GET: RutaController/Create
        public ActionResult Create()
        {
            
                return View();            
            
        }

        // POST: RutaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RutaGuardarModel rutaGuardar)
        {
            try
            {
                this.rutadb.GuardarRuta(rutaGuardar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }

        // GET: RutaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RutaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, RutaEditarModel rutaEditar)
        {
            try
            {
                this.rutadb.EditarRuta(rutaEditar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RutaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RutaController/Delete/5
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
