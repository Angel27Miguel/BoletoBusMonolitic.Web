using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Asiento : BaseEntity
    {
        public int IdBus {  get; set; }
        public int IdAsiento { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get;set; }
        public DateTime FechaCreacion { get; set; }

    }
}
