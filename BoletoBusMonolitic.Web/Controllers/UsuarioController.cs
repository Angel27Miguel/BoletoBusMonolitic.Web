﻿using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMonolitic.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario usuariodb;
        public UsuarioController(IUsuario usuariodb) {
            this.usuariodb = usuariodb;
        }  
        // GET: UsuarioController
        public ActionResult Index()
        {
            var usuario = this.usuariodb.GetUsuarioList();  
            return View(usuario);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            var usuario = this.usuariodb.GetUsuarioList();
            return View(usuario);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            
                return View();
            
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioAgregarModel usuarioAgregar)
        {
            try
            {
                this.usuariodb.AgregarUsuario(usuarioAgregar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UsuarioEditarModel usuarioEditar)
        {
            try
            {
                this.usuariodb.EditarUsuario(usuarioEditar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
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
