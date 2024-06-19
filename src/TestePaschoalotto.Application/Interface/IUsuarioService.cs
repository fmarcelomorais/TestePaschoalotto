using TestePaschoalotto.Application.DTOs;

namespace TestePaschoalotto.Application.Interface
{
    public interface IUsuarioService
    {
        Task CadastraUsuario(UsuarioDTOCreate usuarioDTO);
        Task<UsuarioDTO> ObterUsuarios();
        Task EditarUsuario(UsuarioDTOCreate usuarioDTOCreate);
    }
}
