using TestePaschoalotto.Application.DTOs;

namespace TestePaschoalotto.Application.Interface
{
    public interface IUsuarioService
    {
        Task CadastraUsuario(UsuarioDTOCreate usuarioDTO);
    }
}
