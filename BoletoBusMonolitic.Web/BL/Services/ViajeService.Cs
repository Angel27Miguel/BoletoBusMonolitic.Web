using BoletoBusMonolitic.Web.BL.Interface;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;
using BoletoBusMonolitic.Web.Date.Daos;

namespace BoletoBusMonolitic.Web.BL.Services
{
    public class ViajeService : IViajeService
    {
        private readonly IViajeDb viaje;

        public ViajeService(IViajeDb viaje)
        {
            this.viaje = viaje;
        }
       
        public List<ViajeModel> GetViajeModels()
        {
            return this.viaje.GetViajeModels();
        }
    }
}
