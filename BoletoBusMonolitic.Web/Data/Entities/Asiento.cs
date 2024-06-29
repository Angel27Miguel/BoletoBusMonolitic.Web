using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Asiento : BaseEntity
    {
        [Key]

        public int IdAsiento { get; set; }

        public int IdBus {  get; set; }
        //public int IdAsiento { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get;set; }
        public DateTime FechaCreacion { get; set; }

    }
}
