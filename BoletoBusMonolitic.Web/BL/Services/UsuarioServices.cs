using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuario usuarioDb;
        private readonly ILogger<UsuarioServices> logger;

        public UsuarioServices(IUsuario usuarioDb, ILogger<UsuarioServices> logger)
        {
            this.usuarioDb = usuarioDb;
            this.logger = logger;
        }

        public ServiceResult GuardarUsuario(UsuarioGuardarModel usuarioGuardar)
        {
            ServiceResult result = ValidarUsuario(usuarioGuardar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.usuarioDb.GuardarUsuario(usuarioGuardar);
                this.logger.LogInformation($"Usuario guardado exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarUsuario(UsuarioEditarModel usuarioEditar)
        {
            ServiceResult result = ValidarUsuario(usuarioEditar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.usuarioDb.EditarUsuario(usuarioEditar);
                this.logger.LogInformation($"Usuario editado exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EliminarUsuario(UsuarioEliminarModel usuarioEliminar)
        {
            ServiceResult result = ValidarUsuario(usuarioEliminar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.usuarioDb.EliminarUsuario(usuarioEliminar);
                this.logger.LogInformation($"Usuario eliminado exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error eliminando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetUsuarioList()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.usuarioDb.GetUsuarioList();
                this.logger.LogInformation($"Usuarios obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetUsuarioModel(int idUsuario)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.usuarioDb.GetUsuarioModel(idUsuario);
                this.logger.LogInformation($"Usuario con ID {idUsuario} obtenido exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        private ServiceResult ValidarUsuario(object usuario)
        {
            ServiceResult result = new ServiceResult();
            if (usuario is null)
            {
                result.Success = false;
                result.Message = "El usuario no puede ser nulo";
                return result;
            }

            if (usuario is UsuarioEditarModel editarModel)
            {
                return ValidarCamposUsuario(editarModel.IdUsuario, editarModel.Nombres, editarModel.Apellidos, editarModel.Correo);
            }
            else if (usuario is UsuarioGuardarModel guardarModel)
            {
                return ValidarCamposUsuario(guardarModel.IdUsuario, guardarModel.Nombres, guardarModel.Apellidos, guardarModel.Correo);
            }
            else if (usuario is UsuarioEliminarModel eliminarModel)
            {
                if (eliminarModel.IdUsuario <= 0)
                {
                    result.Success = false;
                    result.Message = "El ID del usuario debe ser mayor a cero";
                }
            }
            return result;
        }

        private ServiceResult ValidarCamposUsuario(int idUsuario, string nombres, string apellidos, string correo)
        {
            ServiceResult result = new ServiceResult();
            if (idUsuario <= 0)
            {
                result.Success = false;
                result.Message = "El ID del usuario debe ser mayor a cero";
                return result;
            }

            if (string.IsNullOrEmpty(nombres))
            {
                result.Success = false;
                result.Message = "Los nombres del usuario no pueden estar vacíos";
                return result;
            }

            if (string.IsNullOrEmpty(apellidos))
            {
                result.Success = false;
                result.Message = "Los apellidos del usuario no pueden estar vacíos";
                return result;
            }

            if (string.IsNullOrEmpty(correo))
            {
                result.Success = false;
                result.Message = "El correo del usuario no puede estar vacío";
                return result;
            }

            return result;
        }
    }
}
