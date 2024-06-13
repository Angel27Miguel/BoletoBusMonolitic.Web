using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MenuRemoveModel
    {
        [Key]
        public int IdPlato { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
