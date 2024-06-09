using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class ReservaDetalle : BaseEntity
    {
        //Atributos de la entidad 
        private int IdReserva { get; set; }
        private int IdAsiento { get; set; }
        private DateTime FechaCreacion { get; set; }

    }
}
//Angel Miguel de la Rosa