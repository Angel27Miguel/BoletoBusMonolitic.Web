namespace BoletoBusMonolitic.Web.Data.Models
{
    public class MenuUpdateModel
    {
        public int MenuUpdateModelId { get; set; }
        public int IdPlato { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public double Precio { get; set; }
        public string Categoria { get; set; } = string.Empty;
    }
}
