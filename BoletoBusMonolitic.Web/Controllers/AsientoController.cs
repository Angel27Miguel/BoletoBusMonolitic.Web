﻿using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class AsientoController : Controller
    {

        private readonly IAsiento asientodb;

        public AsientoController(IAsiento asientodb)
        { 
               this.asientodb = asientodb;
        }

        // GET: AsientoController
        public ActionResult Index()
        {
          var asiento = this.asientodb.GetAsientoList();
            return View(asiento);
        }

        // GET: AsientoController/Details/5
        public ActionResult Details(int id)
        {

            var asiento = this.asientodb.GetAsientoModel(id);
            return View(asiento);
        }

        // GET: AsientoController/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: AsientoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AsientoGuardarModel asientoGuardar)
        {
            try
            {
                asientoGuardar.FechaCreacion = DateTime.Now;
                this.asientodb.AgregarAsiento(asientoGuardar);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();


            }

        }

        // GET: AsientoController/Edit/5
        public ActionResult Edit(int id)
        {

            var asiento = this.asientodb.GetAsientoModel(id);
            return View(asiento);

        }

        // POST: AsientoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AsientoEditarModel asientoEditar)
        {
            try
            {
                asientoEditar.FechaCreacion = DateTime.Now;
                this.asientodb.EditarAsiento(asientoEditar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AsientoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AsientoController/Delete/5
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
