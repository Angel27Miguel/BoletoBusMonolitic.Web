using BoletoBusMonolitic.Web.BL.Core;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.BL.Interface
{
    public interface IUsuarioServices
    {
        ServiceResult GetUsuarioList();
        ServiceResult GetUsuarioModel(int id);
        ServiceResult GuardarUsuario(UsuarioGuardarModel usuarioAgregar);

        ServiceResult EliminarUsuario(UsuarioEliminarModel usuarioEliminar);

        ServiceResult EditarUsuario(UsuarioEditarModel usuarioEditar);
    }
}
