using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class UsuarioDb : IUsuario
    {
        private readonly BoletoBusContext context;

        public UsuarioDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public UsuarioModel GetUsuarioModel(int idUsuario)
        {
            var usuario = this.context.Usuario.Find(idUsuario);

            if (usuario == null)
            {
                throw new ArgumentNullException("Este usuario no se encuentra registrado");
            }

            return new UsuarioModel
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                TipoUsuario = usuario.TipoUsuario,
                FechaCreacion = usuario.FechaCreacion
            };
        }

        public void AgregarUsuario(UsuarioAgregarModel usuarioAgregar)
        {
            Usuario usuario = new Usuario()
            {
                Nombre = usuarioAgregar.Nombres,
                Apellidos = usuarioAgregar.Apellidos,
                Correo = usuarioAgregar.Correo,
                Clave = usuarioAgregar.Clave, // Asegúrate de encriptar la contraseña antes de guardarla
                TipoUsuario = usuarioAgregar.TipoUsuario,
                FechaCreacion = usuarioAgregar.FechaCreacion ?? DateTime.Now
            };

            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public void EditarUsuario(UsuarioEditarModel usuarioEditar)
        {
            var usuario = this.context.Usuario.Find(usuarioEditar.IdUsuario);

            if (usuario == null)
            {
                throw new ArgumentNullException("Usuario no encontrado");
            }

            usuario.Nombre = usuarioEditar.Nombres;
            usuario.Apellidos = usuarioEditar.Apellidos;
            usuario.Correo = usuarioEditar.Correo;
            usuario.Clave = usuarioEditar.Clave; 
            usuario.TipoUsuario = usuarioEditar.TipoUsuario;
            usuario.FechaCreacion = (DateTime)usuarioEditar.FechaCreacion;

            this.context.Usuario.Update(usuario);
            this.context.SaveChanges();
        }

        public void EliminarUsuario(UsuarioEliminarModel UsuarioEliminar)
        {
            var usuarioModelEliminar = this.context.Usuario.Find(UsuarioEliminar.IdUsuario);
            if (usuarioModelEliminar == null)
            {
                throw new ArgumentNullException("Usuario no encontrado");
            }

            this.context.Remove(usuarioModelEliminar);
            this.context.SaveChanges();
        }

        public List<UsuarioModel> GetUsuarioModels()
        {
            return this.context.Usuario.Select(us => new UsuarioModel()
            {
                IdUsuario = us.IdUsuario,
                Nombre = us.Nombre,
                Apellidos = us.Apellidos,
                Correo = us.Correo,
                TipoUsuario = us.TipoUsuario,
                FechaCreacion = us.FechaCreacion
            }).ToList();
        }
    }
}
