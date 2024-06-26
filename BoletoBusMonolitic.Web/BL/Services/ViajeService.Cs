using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class ViajeService : IViajeService
    {
        private readonly IViajeDb viajeDb;
        private readonly ILogger<ViajeService> logger;

        public ViajeService(IViajeDb viajeDb, ILogger<ViajeService> logger)
        {
            this.logger = logger;
            this.viajeDb = viajeDb;
        }

        public ServiceResult GetViajes()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = viajeDb.GetViajeModels();
                this.logger.LogInformation("Viajes obtenidos exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los viajes";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetViaje(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.viajeDb.GetViaje(id);
                this.logger.LogInformation($"Viaje con ID {id} obtenido exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarViaje(ViajeEditarModel viajeEditar)
        {
            ServiceResult result = ValidarViaje(viajeEditar);

            if (!result.Success)
                return result;

            try
            {
                this.viajeDb.EditarViaje(viajeEditar);
                this.logger.LogInformation($"Viaje con ID {viajeEditar.IdViaje} editado exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EliminarViaje(ViajeEliminarModel viajeEliminar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (viajeEliminar is null)
                {
                    result.Success = false;
                    result.Message = "El viaje no puede ser nulo.";
                    return result;
                }
                this.viajeDb.EliminarViaje(viajeEliminar);
                this.logger.LogInformation($"Viaje con ID {viajeEliminar.IdViaje} eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error eliminando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GuardarViaje(ViajeGuardarModel viajeGuardar)
        {
            ServiceResult result = ValidarViaje(viajeGuardar);

            if (!result.Success)
                return result;

            try
            {
                this.viajeDb.GuardarViaje(viajeGuardar);
                this.logger.LogInformation($"Viaje guardado exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        private ServiceResult ValidarViaje(object viaje)
        {
            ServiceResult result = new ServiceResult();

            if (viaje is null)
            {
                result.Success = false;
                result.Message = "El viaje no puede ser nulo.";
                return result;
            }

            if (viaje is ViajeEditarModel editarModel)
            {
                return ValidarCamposViaje(editarModel.IdBus, editarModel.IdRuta, editarModel.HoraSalida, editarModel.HoraLlegada, editarModel.Precio, editarModel.TotalAsientos, editarModel.AsientosReservados);
            }
            else if (viaje is ViajeGuardarModel guardarModel)
            {
                return ValidarCamposViaje(guardarModel.IdBus, guardarModel.IdRuta, guardarModel.HoraSalida, guardarModel.HoraLlegada, guardarModel.Precio, guardarModel.TotalAsientos, guardarModel.AsientosReservados);
            }

            return result;
        }

        private ServiceResult ValidarCamposViaje(int IdBus, int IdRuta, TimeSpan HoraSalida, TimeSpan HoraLlegada, decimal Precio, int TotalAsientos, int AsientosReservados)
        {
            ServiceResult result = new ServiceResult();

            if (IdBus <= 0)
            {
                result.Success = false;
                result.Message = "El ID del bus es requerido.";
                return result;
            }

            if (IdRuta <= 0)
            {
                result.Success = false;
                result.Message = "El ID de la ruta es requerido.";
                return result;
            }

            if (TotalAsientos <= 0)
            {
                result.Success = false;
                result.Message = "El total de asientos es requerido.";
                return result;
            }

            if (AsientosReservados < 0)
            {
                result.Success = false;
                result.Message = "Los asientos reservados no pueden ser negativos.";
                return result;
            }

            if (HoraSalida.TotalHours > 99999.99 || HoraSalida.TotalHours < 0)
            {
                result.Success = false;
                result.Message = "La hora de salida debe ser un valor válido.";
                return result;
            }

            if (HoraLlegada.TotalHours > 99999.99 || HoraLlegada.TotalHours < 0)
            {
                result.Success = false;
                result.Message = "La hora de llegada debe ser un valor válido.";
                return result;
            }

            if (Precio < 0 || Precio > 9999999.99m)
            {
                result.Success = false;
                result.Message = "El precio debe ser un valor válido.";
                return result;
            }

            return result;
        }
    }
}
