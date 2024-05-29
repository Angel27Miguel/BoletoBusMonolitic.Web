using System;
using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data{
    public class Cliente:BaseEntity {

        private string? Nombre;
        private int Telefono;
        private string? Correo;

        public Cliente(int id, string? Nombre, int Telefono, string? Correo ) : base(id)
        {
        this.Nombre = Nombre;
        this.Telefono = Telefono;
        this.Correo = Correo;
        }
    }
}

/*Daniel Alexander Dominguez*/
