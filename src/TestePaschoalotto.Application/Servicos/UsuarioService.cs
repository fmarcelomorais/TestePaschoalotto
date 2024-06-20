using AutoMapper;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Application.Interface;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;
using TestePaschoalotto.Domain.ValueObjects;

namespace TestePaschoalotto.Application.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsuarioService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task CadastraUsuario(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuario
            {
                Gender = usuarioDTO.Gender,
                Name = _mapper.Map<Name>(usuarioDTO.Name),
                Location = _mapper.Map<Location>(usuarioDTO.Location),
                Email = usuarioDTO.Email,
                Login = _mapper.Map<Login>(usuarioDTO.Login),
                Dob = _mapper.Map<Dob>(usuarioDTO.Dob),
                Registered = _mapper.Map<Registered>(usuarioDTO.Registered),
                Phone = usuarioDTO.Phone,
                Cell = usuarioDTO.Cell,
                Id = _mapper.Map<Id>(usuarioDTO.Id),
                Picture = _mapper.Map<Picture>(usuarioDTO.Picture)

            };
            



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
