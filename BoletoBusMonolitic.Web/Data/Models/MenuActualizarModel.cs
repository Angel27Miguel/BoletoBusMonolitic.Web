using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MenuActualizarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPlato { get; set; }
        public string? Nombre { get; set; } 
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; } 
    }
}
