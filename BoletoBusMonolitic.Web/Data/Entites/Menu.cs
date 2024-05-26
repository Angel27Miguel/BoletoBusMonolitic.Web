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

        public Menu(int id) : base(id)
        { 
        }
    }
}
