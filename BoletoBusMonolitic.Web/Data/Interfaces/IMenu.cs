﻿using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenuList();
        public void Mostrar();
        public void Agregar();
        public void Actualizar();
        public void Eliminar();
    }
}