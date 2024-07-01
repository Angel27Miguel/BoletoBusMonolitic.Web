using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.Interfaces
{
    public interface IUsuario
    {
        List<UsuarioModel> GetUsuarioList();
        UsuarioModel GetUsuarioModel(int id);
        public void GuardarUsuario(UsuarioGuardarModel usuarioAgregar);

        public void EliminarUsuario(UsuarioEliminarModel usuarioEliminar);

        public void EditarUsuario(UsuarioEditarModel usuarioEditar);

        
    }
}
