using System.Linq.Expressions;
using TestePaschoalotto.Application.DTOs;

namespace TestePaschoalotto.Application.Interface
{
    public interface IUsuarioService
    {
        Task CadastraUsuario(UsuarioDTO usuarioDTO);
        Task<List<UsuarioDTO>> ObterUsuarios();
        Task EditarUsuario(UsuarioDTO usuarioDTO);
        Task<UsuarioDTO> ObterUsuario(string filtro);
    }
}
