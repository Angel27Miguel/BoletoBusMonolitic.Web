using BoletoBusMonolitic.Web.Data.Core;
using System;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Menu : BaseEntity
    {
        public int IdPlato { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
    }
}
