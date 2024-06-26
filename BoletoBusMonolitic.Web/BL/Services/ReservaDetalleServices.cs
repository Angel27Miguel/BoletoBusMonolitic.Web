using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class ReservaDetalleServices : IReservaDetalleServices
    {
        private readonly IReservaDetalle reservaDetalleDb;
        private readonly ILogger<ReservaDetalleServices> logger;

        public ReservaDetalleServices(IReservaDetalle reservaDetalleDb, ILogger<ReservaDetalleServices> logger)
        {
            this.logger = logger;
            this.reservaDetalleDb = reservaDetalleDb;
        }

        public ServiceResult GetReservaDetalles()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = reservaDetalleDb.GetReservaDetalleList();
                this.logger.LogInformation("Detalles de reserva obtenidos exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los detalles de reserva";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetReservaDetalle(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.reservaDetalleDb.GetReservaDetalleModel(id);
                this.logger.LogInformation($"Detalle de reserva con ID {id} obtenido exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarReservaDetalle(ReservaDetalleModelEdit reservaDetalleEdit)
        {
            ServiceResult result = ValidarReservaDetalle(reservaDetalleEdit);

            if (!result.Success)
                return result;

            try
            {
                this.reservaDetalleDb.EditarReservaDetalle(reservaDetalleEdit);
                this.logger.LogInformation($"Detalle de reserva con ID {reservaDetalleEdit.IdReservaDetalle} editado exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GuardarReservaDetalle(ReservaDetalleModelGuardar reservaDetalleGuardar)
        {
            ServiceResult result = ValidarReservaDetalle(reservaDetalleGuardar);

            if (!result.Success)
                return result;

            try
            {
                this.reservaDetalleDb.GuardarReservaDetalle(reservaDetalleGuardar);
                this.logger.LogInformation("Detalle de reserva guardado exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        private ServiceResult ValidarReservaDetalle(object reservaDetalle)
        {
            ServiceResult result = new ServiceResult();

            if (reservaDetalle is null)
            {
                result.Success = false;
                result.Message = "El detalle de la reserva no puede ser nulo.";
                return result;
            }

            if (reservaDetalle is ReservaDetalleModelEdit editarModel)
            {
                return ValidarCamposReservaDetalle(editarModel.IdReserva, editarModel.IdAsiento);
            }
            else if (reservaDetalle is ReservaDetalleModelGuardar guardarModel)
            {
                return ValidarCamposReservaDetalle(guardarModel.IdReserva, guardarModel.IdAsiento);
            }

            return result;
        }

        private ServiceResult ValidarCamposReservaDetalle(int IdReserva, int IdAsiento)
        {
            ServiceResult result = new ServiceResult();

            if (IdReserva <= 0)
            {
                result.Success = false;
                result.Message = "El ID de la reserva es requerido.";
                return result;
            }

            if (IdAsiento <= 0)
            {
                result.Success = false;
                result.Message = "El ID del asiento es requerido.";
                return result;
            }

            return result;
        }
    }
}
