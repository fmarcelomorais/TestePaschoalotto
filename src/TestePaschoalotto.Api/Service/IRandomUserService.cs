using TestePaschoalotto.Application.DTOs;

namespace TestePaschoalotto.Api.Service
{
    public interface IRandomUserService
    {
        Task<UsuarioDTO> NovoUsuario( HttpClient httpClient, string baseAddress);
    }
}
