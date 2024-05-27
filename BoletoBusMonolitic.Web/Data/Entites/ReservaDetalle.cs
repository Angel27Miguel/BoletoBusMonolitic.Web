using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class ReservaDetalle : BaseEntity
    {
        //Atributos de la entidad 
        private int IdReserva;
        private int IdAsiento;
        private DateTime FechaCreacion;
        public ReservaDetalle(int id, int idReserva, int idAsiento, DateTime fechaCreacion) : base(id)
        {
            this.IdReserva = idReserva;
            this.IdAsiento = idAsiento;
            this.FechaCreacion = fechaCreacion;
        }
    }
}
//Angel Miguel de la Rosa