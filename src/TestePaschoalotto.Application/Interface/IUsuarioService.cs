using TestePaschoalotto.Application.DTOs;

namespace TestePaschoalotto.Application.Interface
{
    public interface IUsuarioService
    {
        Task CadastraUsuario(UsuarioDTO usuarioDTO);
        Task<UsuarioDTO> ObterUsuarios();
        Task EditarUsuario(UsuarioDTO usuarioDTO);
    }
}
