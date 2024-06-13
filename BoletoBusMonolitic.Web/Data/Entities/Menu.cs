using BoletoBusMonolitic.Web.Data.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public class Menu : BaseEntity
    {
        [Key]
        public int IdPlato { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }
        public string? Categoria { get; set; } 
    }
}
