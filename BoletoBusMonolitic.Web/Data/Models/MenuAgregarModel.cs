using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MenuAgregarModel
    {
        [Key]
        public int IdPlato { get; set; }
        public string? Nombre { get; set; } 
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; }
    }
}
