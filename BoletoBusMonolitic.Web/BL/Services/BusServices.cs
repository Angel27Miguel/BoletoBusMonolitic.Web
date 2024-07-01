using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class BusServices : IBusServices
    {
        private readonly IBus busDb;
        private readonly ILogger<BusServices> logger;

        public BusServices(IBus busDb, ILogger<BusServices> logger)
        {
            this.logger = logger;
            this.busDb = busDb;
        }

        public ServiceResult GuardarBus(BusGuardarModel busGuardar)
        {
            ServiceResult result = ValidarBus(busGuardar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.busDb.GuardarBus(busGuardar);
                this.logger.LogInformation($"Bus guardado exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarBus(BusEditarModel busEditar)
        {
            ServiceResult result = ValidarBus(busEditar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.busDb.EditarBus(busEditar);
                this.logger.LogInformation($"Bus editado exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EliminarBus(BusEliminarModel busEliminar)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetBusList()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.busDb.GetBusList();
                this.logger.LogInformation($"Buses obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetBusModel(int idBus)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.busDb.GetBusModel(idBus);
                this.logger.LogInformation($"Bus con ID {idBus} obtenido exitosamente");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        private ServiceResult ValidarBus(object bus)
        {
            ServiceResult result = new ServiceResult();
            if (bus is null)
            {
                result.Success = false;
                result.Message = "El bus no puede ser nulo";
                return result;
            }

            if (bus is BusEditarModel editarModel)
            {
                return ValidarCamposBus(editarModel.IdBus, editarModel.Nombre!, editarModel.CapacidadTotal);
            }
            else if (bus is BusGuardarModel guardarModel)
            {
                return ValidarCamposBus(guardarModel.IdBus, guardarModel.Nombre!, guardarModel.CapacidadTotal);
            }
            else if (bus is BusEliminarModel eliminarModel)
            {
                if (eliminarModel.IdBus <= 0)
                {
                    result.Success = false;
                    result.Message = "El ID del bus debe ser mayor a cero";
                }
            }
            return result;
        }

        private ServiceResult ValidarCamposBus(int IdBus, string NombreBus, int Capacidad)
        {
            ServiceResult result = new ServiceResult();
            if (IdBus <= 0)
            {
                result.Success = false;
                result.Message = "El ID del bus debe ser mayor a cero";
                return result;
            }

            if (string.IsNullOrEmpty(NombreBus))
            {
                result.Success = false;
                result.Message = "El nombre del bus no puede estar vacío";
                return result;
            }

            if (Capacidad <= 0)
            {
                result.Success = false;
                result.Message = "La capacidad del bus debe ser mayor a cero";
                return result;
            }

            return result;
        }
    }
}

