using System;
using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data{
    public class Cliente:BaseEntity {
        public int IdCliente;
        public string Nombre;
        public int Telefono;
        public  string?Correo;

        public Cliente()
        {
        }

        public Cliente(int id, string? Nombre, int Telefono, string? Correo ) : base()
        {
        this.Nombre = Nombre;
        this.Telefono = Telefono;
        this.Correo = Correo;
        }
    }
}

/*Daniel Alexander Dominguez*/
