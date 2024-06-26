﻿using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoDb pedidoService;

        public PedidoController(IPedidoDb pedidoDb)
        {
            this.pedidoService = pedidoDb;
        }
        // GET: PedidoController
        public ActionResult Index()
        {
            var Pedido = this.pedidoService.GetPedidos();
            return View(Pedido);
        }

        // GET: PedidoController/Details/5
        public ActionResult Details(int id)
        {
            var pedido = this.pedidoService.GetPedidoModel(id);
            return View(pedido);
        }

        // GET: PedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoAgregarModel pedidoAdd)
        {
            try
            {
                this.pedidoService.Agregar(pedidoAdd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            var pedido = this.pedidoService.GetPedidoModel(id);
            return View(pedido);
        }

        // POST: PedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PedidoActualizarModel pedidoActualizar)
        {
            try
            {
                this.pedidoService.Actualizar(pedidoActualizar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PedidoController/Delete/5
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
