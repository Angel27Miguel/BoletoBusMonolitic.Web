using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IAsiento
    {
        List<Asiento> GetAsientoList();

        public void agregarAsiento();

        public void eliminarAsiento();
        
        public void actualizarAsiento();

        public void buscarAsiento();
    }
}
