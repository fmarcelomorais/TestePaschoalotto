using AutoMapper;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Application.Interface;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly ILoginRepository _loginRepository;
        private readonly IPictureRepository _pictureRepository;
        private readonly IMapper _mapper;
        public UsuarioService(IUserRepository userRepository, 
            ILocationRepository locationRepository, ILoginRepository loginRepository, 
            IPictureRepository pictureRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _locationRepository = locationRepository;
            _loginRepository = loginRepository;
            _pictureRepository = pictureRepository;
            _mapper = mapper;

        }
        public async Task CadastraUsuario(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            await _userRepository.Create(usuario);

        }

        public Task EditarUsuario(UsuarioDTO usuarioDTOCreate)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioDTO> ObterUsuarios()
        {

            var usuario = new UsuarioDTO
            {

            };
            return usuario;
        }
    }
}
