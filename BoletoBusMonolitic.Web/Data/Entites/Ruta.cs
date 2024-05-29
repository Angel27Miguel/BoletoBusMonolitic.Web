using BoletoBusMonolitic.Web.Data.Core;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class Ruta : BaseEntity
    {
        //atributos
        private string origen;
        private string destino;
        private string FechaCreacion;
        public Ruta(int id) : base(id)
        {
        }
    }
}
