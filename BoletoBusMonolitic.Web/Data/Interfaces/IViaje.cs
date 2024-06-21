﻿using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public interface IViajeDb
    {
        List<ViajeModel> GetViajeModels();
        ViajeModel GetViaje(int IdViaje);
        void GuardarViaje(ViajeGuardarModel viajeGuardar);
        void EditarViaje(ViajeEditarModel viajeEditar);
        void EliminarViaje(ViajeEliminarModel viajeEliminar);

        


    }
}
//Angel Miguel de la Rosa