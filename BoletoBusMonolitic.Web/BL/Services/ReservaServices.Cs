using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.BL.Interfaces;
using BoletoBusMonolitic.Web.Data.DbObject;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class ReservaServices : IReservaServices
    {
        private readonly IReserva reservaDb;
        private readonly ILogger<ReservaServices> logger;

        public ReservaServices(IReserva reservaDb, ILogger<ReservaServices> logger)
        {
            this.reservaDb = reservaDb;
            this.logger = logger;
        }

        public ServiceResult GetReservas()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = reservaDb.GetReservaList();
                this.logger.LogInformation("Reservas obtenidas exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo las reservas";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GetReserva(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.reservaDb.GetReservaModel(id);
                this.logger.LogInformation($"Reserva con ID {id} obtenida exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarReserva(ReservaEditarModel reservaEditar)
        {
            ServiceResult result = ValidarReserva(reservaEditar);

            if (!result.Success)
                return result;

            try
            {
                this.reservaDb.EditarReserva(reservaEditar);
                this.logger.LogInformation($"Reserva con ID {reservaEditar.IdReserva} editada exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EliminarReserva(ReservaEliminarModel reservaEliminar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (reservaEliminar is null)
                {
                    result.Success = false;
                    result.Message = "La reserva no puede ser nula.";
                    return result;
                }
                this.reservaDb.EliminarReserva(reservaEliminar);
                this.logger.LogInformation($"Reserva con ID {reservaEliminar.IdReserva} eliminada exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error eliminando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult GuardarReserva(ReservaGuardarModel reservaGuardar)
        {
            ServiceResult result = ValidarReserva(reservaGuardar);

            if (!result.Success)
                return result;

            try
            {
                this.reservaDb.GuardarReserva(reservaGuardar);
                this.logger.LogInformation($"Reserva guardada exitosamente.");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        private ServiceResult ValidarReserva(object reserva)
        {
            ServiceResult result = new ServiceResult();

            if (reserva is null)
            {
                result.Success = false;
                result.Message = "La reserva no puede ser nula.";
                return result;
            }

            if (reserva is ReservaEditarModel editarModel)
            {
                return ValidarCamposReserva(editarModel.IdViaje, editarModel.IdPasajero, editarModel.AsientosReservados, editarModel.MontoTotal);
            }
            else if (reserva is ReservaGuardarModel guardarModel)
            {
                return ValidarCamposReserva(guardarModel.IdViaje, guardarModel.IdPasajero, guardarModel.AsientosReservados, guardarModel.MontoTotal);
            }

            return result;
        }

        private ServiceResult ValidarCamposReserva(int IdViaje, int IdPasajero, int AsientosReservados, decimal MontoTotal)
        {
            ServiceResult result = new ServiceResult();

            if (IdViaje <= 0)
            {
                result.Success = false;
                result.Message = "El ID del viaje es requerido.";
                return result;
            }

            if (IdPasajero <= 0)
            {
                result.Success = false;
                result.Message = "El ID del pasajero es requerido.";
                return result;
            }

            if (AsientosReservados < 0)
            {
                result.Success = false;
                result.Message = "Los asientos reservados no pueden ser negativos.";
                return result;
            }

            if (MontoTotal < 0 || MontoTotal > 99999999.99m)
            {
                result.Success = false;
                result.Message = "El monto total debe ser un valor válido.";
                return result;
            }

            return result;
        }
    }
}
