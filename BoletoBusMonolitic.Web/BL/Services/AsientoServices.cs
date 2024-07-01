using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq.Expressions;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class AsientoServices : IAsientoServices
    {
        private readonly IAsiento asientoDb;
        private readonly ILogger<AsientoServices> logger;

        public AsientoServices(IAsiento asientoDb, ILogger<AsientoServices> logger)
        {
            this.logger = logger;
            this.asientoDb = asientoDb;

        }
        public ServiceResult GuardarAsiento(AsientoGuardarModel asientoGuardar)
        {
            ServiceResult result = ValidarAsiento(asientoGuardar);

            if (!result.Success) 
            { 
                return result;  
            }

            try 
            {
                this.asientoDb.GuardarAsiento(asientoGuardar);
                this.logger.LogInformation($"Asiento guardado exitosamente");
            
            }
            catch (Exception ex) 
            {
                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EditarAsiento(AsientoEditarModel asientoEditar)
        {
            ServiceResult result = ValidarAsiento(asientoEditar);

            if (!result.Success)
            {
                return result;
            }

            try
            {
                this.asientoDb.EditarAsiento(asientoEditar);
                this.logger.LogInformation($"Asiento guardado exitosamente");

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error editando los datos";
                this.logger.LogError(ex, result.Message);
            }
            return result;
        }

        public ServiceResult EliminarAsiento(AsientoEliminarModel asientoEliminar)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetAsientoList()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.asientoDb.GetAsientoList();
                this.logger.LogInformation($"Asientos obtenidos exitosamente");

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);

            }
            return result;
        }

        public ServiceResult GetAsientoModel(int idAsiento)
        {
           ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.asientoDb.GetAsientoModel(idAsiento);
                this.logger.LogInformation($"Empleado con ID {idAsiento} obtenido exitosamente");
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            
            }
            return result;
        }
        private ServiceResult ValidarAsiento(object asiento)
        {
            ServiceResult result = new ServiceResult();
            if (asiento is null)
            {
                result.Success = false;
                result.Message = "el piso no puede ser nulo";
                return result;
            }

            if (asiento is AsientoEditarModel editarModel)
            {
               
                return ValidarCamposAsiento(editarModel.NumeroAsiento, editarModel.IdBus, editarModel.NumeroPiso);

            }

            else if (asiento is AsientoGuardarModel guardarModel)
            {
                return ValidarCamposAsiento(guardarModel.NumeroAsiento, guardarModel.NumeroPiso, guardarModel.IdBus);
            }
            return result;
        }


        private ServiceResult ValidarCamposAsiento(int IdBus, int NumeroPiso, int NumeroAsiento) 
        {
            ServiceResult result = new ServiceResult();
            if (NumeroPiso <= 0) 
            {
                result.Success = false;
                result.Message = "el numero de piso debe ser mayor a cero";
                return result;
            }

            if (NumeroAsiento <= 0)
            {
                result.Success = false;
                result.Message = "el numero de Asiento debe ser mayor a cero";
                return result;
            }

            if (IdBus <= 0)
            {
                result.Success = false;
                result.Message = "el numero de Asiento debe ser mayor a cero";
                return result;
            }
            return result;
        }   
    }
}
