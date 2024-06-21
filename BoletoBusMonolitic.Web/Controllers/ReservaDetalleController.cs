﻿using BoletoBusMonolitic.Web.Data.DbObject;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using BoletoBusMonolitic.Web.Date.Daos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class ReservaDetalleController : Controller
    {
        private readonly IReservaDetalle reservaDetalleDb;

        public ReservaDetalleController(IReservaDetalle reservaDetalleDb)
        {
            this.reservaDetalleDb = reservaDetalleDb;
        }
        // GET: ReservaDetalleController
        public ActionResult Index()
        {
            var reservaD = this.reservaDetalleDb.GetReservaDetalleList();
            return View(reservaD); ;
        }

        // GET: ReservaDetalleController/Details/5
        public ActionResult Details(int id)
        {
            var reserva = this.reservaDetalleDb.GetReservaDetalleModel(id);
            return View(reserva);
        }

        // GET: ReservaDetalleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaDetalleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaDetalleModelGuardar reservaDetalle)
        {
            try
            {
                reservaDetalle.FechaCreacion = DateTime.Now;
                this.reservaDetalleDb.GuardarReservaDetalle(reservaDetalle);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaDetalleController/Edit/5
        public ActionResult Edit(int id)
        {
			var reserva = this.reservaDetalleDb.GetReservaDetalleModel(id);
			return View(reserva);
		}

        // POST: ReservaDetalleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservaDetalleModelEdit reservaEditar)
        {
            try
            {
				reservaEditar.FechaCreacion = DateTime.Now;
				this.reservaDetalleDb.EditarReservaDetalle(reservaEditar);
				return RedirectToAction(nameof(Index));
			}
            catch
            {
                return View();
            }
        }

        // GET: ReservaDetalleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservaDetalleController/Delete/5
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