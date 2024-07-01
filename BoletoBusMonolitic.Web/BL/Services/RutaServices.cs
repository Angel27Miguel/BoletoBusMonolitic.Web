using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class RutaServices : IRutaServices
    {
        private readonly IRuta rutaDb;
        private readonly ILogger<RutaServices> logger;

        public RutaServices(IRuta rutaDb, ILogger<RutaServices> logger)
        {
            this.rutaDb = rutaDb;
            this.logger = logger;
        }

        public ServiceResult GuardarRuta(RutaGuardarModel rutaGuardar)
        {
            ServiceResult result = ValidarRuta(rutaGuardar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.rutaDb.GuardarRuta(rutaGuardar);
                this.logger.LogInformation($"Ruta guardada exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarRuta(RutaEditarModel rutaEditar)
        {
            ServiceResult result = ValidarRuta(rutaEditar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.rutaDb.EditarRuta(rutaEditar);
                this.logger.LogInformation($"Ruta editada exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EliminarRuta(RutaEliminarModel rutaEliminar)
        {
            ServiceResult result = ValidarRuta(rutaEliminar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.rutaDb.EliminarRuta(rutaEliminar);
                this.logger.LogInformation($"Ruta eliminada exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error eliminando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetRutaList()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.rutaDb.GetRutaList();
                this.logger.LogInformation($"Rutas obtenidas exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetRutaModel(int idRuta)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.rutaDb.GetRutaModel(idRuta);
                this.logger.LogInformation($"Ruta con ID {idRuta} obtenida exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        private ServiceResult ValidarRuta(object ruta)
        {
            ServiceResult result = new ServiceResult();
            if (ruta is null)
            {
                result.Success = false;
                result.Message = "La ruta no puede ser nula";
                return result;
            }

            if (ruta is RutaEditarModel editarModel)
            {
                return ValidarCamposRuta(editarModel.IdRuta, editarModel.Origen!, editarModel.Destino!);
            }
            else if (ruta is RutaGuardarModel guardarModel)
            {
                return ValidarCamposRuta(guardarModel.IdRuta, guardarModel.Origen!, guardarModel.Destino!);
            }
            else if (ruta is RutaEliminarModel eliminarModel)
            {
                if (eliminarModel.IdRuta <= 0)
                {
                    result.Success = false;
                    result.Message = "El ID de la ruta debe ser mayor a cero";
                }
            }
            return result;
        }

        private ServiceResult ValidarCamposRuta(int idRuta, string origen, string destino)
        {
            ServiceResult result = new ServiceResult();
            if (idRuta <= 0)
            {
                result.Success = false;
                result.Message = "El ID de la ruta debe ser mayor a cero";
                return result;
            }

            if (string.IsNullOrEmpty(origen))
            {
                result.Success = false;
                result.Message = "El origen de la ruta no puede estar vacío";
                return result;
            }

            if (string.IsNullOrEmpty(destino))
            {
                result.Success = false;
                result.Message = "El destino de la ruta no puede estar vacío";
                return result;
            }

            return result;
        }
    }
}

