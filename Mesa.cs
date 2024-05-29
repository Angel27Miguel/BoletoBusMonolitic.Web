using System;
using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data
{
	public class Mesa: BaseEntity
	{
        private int Numerodemesa;
        private int Capacidad;
        private string? Ubicacion;
        private string? Estado;

        public Mesa(int id, int Numerodemesa, int Capacidad, string? Ubicacion, string? Estado ) : base(id)
        {
            this.Numerodemesa = Numerodemesa;
            this.Capacidad = Capacidad;
            this.Ubicacion = Ubicacion;
            this.Estado = Estado;
        }
    }
}

/*Daniel Alexander Dominguez*/