using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class AsientoEliminarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdAsiento { get; set; }
    }
}
