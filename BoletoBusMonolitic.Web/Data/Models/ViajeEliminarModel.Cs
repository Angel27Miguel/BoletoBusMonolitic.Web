using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class ViajeEliminarModel
    {
        [Key]
        public int IdViaje { get; set; }
        public int ViajeDelete { get; set; }
       
    }
}
