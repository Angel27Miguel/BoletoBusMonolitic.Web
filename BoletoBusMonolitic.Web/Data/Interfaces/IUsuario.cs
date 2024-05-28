using BoletoBusMonolitic.Web.Data.Entites;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> GetUsuarioList();
        public void crearUsuario();

        public void eliminarUsuario();

        public void actualizarUsuario();

        public void buscarUsuario();
    }
}
