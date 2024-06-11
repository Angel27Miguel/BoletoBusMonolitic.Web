using BoletoBusMonolitic.Web.Data.Core;
using System;

namespace BoletoBusMonolitic.Web.Data.Entities
{
    public class Menu : BaseEntity
    {
        public int MenuId { get; set; }
        public int IdPlato { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public double Precio { get; set; }
        public string Categoria { get; set; } = string.Empty;
    }
}
