using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class BusEliminarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdBus { get; set; } 
    }
}
