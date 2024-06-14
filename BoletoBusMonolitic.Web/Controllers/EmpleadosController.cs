using BoletoBusMonolitic.Web.Data.DbObject;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using BoletoBusMonolitic.Web.Date.Daos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleados empleados;

        public EmpleadosController(IEmpleados empleados)
        {
            this.empleados = empleados;
        }

        // GET: EmpleadosController
        public ActionResult Index()
        {

            var empleado = this.empleados.GetEmpleados();
            return View(empleado);
        }

        // GET: EmpleadosController/Details/5
        public ActionResult Details(int id)
        {
            var empleado = this.empleados.GetEmpleado(id);
            return View(empleado);
        }

        // GET: EmpleadosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadosGuardarModel empleadosGuardarModel)
        {
            try
            {

                
                empleados.GuardarEmpleado(empleadosGuardarModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadosController/Edit/5
        public ActionResult Edit(int id)
        {
            var empleado = this.empleados.GetEmpleado(id);
            return View(empleado);
        }

        // POST: EmpleadosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadosEditarModel empleadosEditar)
        {
            try
            {

                this.empleados.EditarEmpleados(empleadosEditar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadosController/Delete/5
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
