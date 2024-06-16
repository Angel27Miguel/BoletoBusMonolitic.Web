using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MenuActualizarModel
    {
        [Key]
        public int IdPlato { get; set; }
        public string? Nombre { get; set; } 
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; } 
    }
}
