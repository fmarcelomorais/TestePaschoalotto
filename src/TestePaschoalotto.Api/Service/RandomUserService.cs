using Newtonsoft.Json;
using System.Text.Json;
using TestePaschoalotto.Application.DTOs;

namespace TestePaschoalotto.Api.Service
{
    public static class RandomUserService
    {
        
        public static async Task<UsuarioDTO> NovoUsuario(HttpClient httpClient, string baseAddress)
        {
            httpClient.BaseAddress = new Uri(baseAddress);
            HttpResponseMessage request = await httpClient.GetAsync("");
            request.EnsureSuccessStatusCode();

            var response = await request.Content.ReadAsStringAsync();
                       
            UsuarioDTO usuario = JsonConvert.DeserializeObject<UsuarioDTO>(response);

            return usuario;
            
        }
    }
}
