using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Menu : BaseEntity
    {
        //atributos
        private int IdPlato;
        private string Nombre;
        private string Descripcion;
        private double Precio;
        private string Categoria;

        public Menu(int Id, int IdPlato, string Nombre, string Descripcion, double Precio, string Categoria) : base(Id)
        {
            this.IdPlato = IdPlato;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.Categoria = Categoria;
        }
    }
}
