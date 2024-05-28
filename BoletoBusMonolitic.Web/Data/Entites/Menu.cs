using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Menu : BaseEntity
    {
        private int IdPlato;
        private string Nombre;
        private string Descripcion;
        private double Precio;
        private string Categoria;

        public Menu(int id, int IdPlato, string Nombre, string Descripcion, double Precio, string Categoria) : base(id)
        { 
            this.IdPlato = IdPlato;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.Categoria = Categoria; 
        }
    }
}
