using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Bus : BaseEntity
    {
        //atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdBus { get; set; }
        public int IdAsiento { get; set; }
        public int NumeroPlaca { get; set; }
        public string Nombre { get; set; }
        public int CapacidadPiso1 { get; set; }
        public int CapacidadPiso2 { get; set; }
        public int CapacidadTotal { get; set; }
        public bool Disponible { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}
