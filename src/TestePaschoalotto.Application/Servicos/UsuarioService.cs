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

            var name = _mapper.Map<Name>(usuarioDTO.Name);
            var login = _mapper.Map<Login>(usuarioDTO.Login);
            var dob = _mapper.Map<Dob>(usuarioDTO.Dob);
            var registered = _mapper.Map<Registered>(usuarioDTO.Registered);
            var id = _mapper.Map<Id>(usuarioDTO.Id);
            var street = new Street
            {
                Number = usuarioDTO.Location.Street.Number,
                Name = usuarioDTO.Location.Street.Name,
            };
            var coordinates = new Coordinates
            {
                Latitude = usuarioDTO.Location.Coordinates.Latitude,
                Longitude = usuarioDTO.Location.Coordinates.Longitude,
            };
            var timezone = new Timezone
            {
                Offset = usuarioDTO.Location.Timezone.Offset,
                Description = usuarioDTO.Location.Timezone.Description,
            };
            var location = new Location
            {
                City = usuarioDTO.Location.City,
                State = usuarioDTO.Location.State,
                Country = usuarioDTO.Location.Country,
                Postcode = usuarioDTO.Location.Postcode,
                Street = street,
                Coordinates = coordinates,
                Timezone = timezone
                
            };
            var picture = _mapper.Map<Picture>(usuarioDTO.Picture);

            var usuario = new Usuario
            {
                Gender = usuarioDTO.Gender,
                Name = name,
                Location = location,
                Email = usuarioDTO.Email,
                Login = login,
                Dob = dob,
                Registered = registered,
                Phone = usuarioDTO.Phone,
                Cell = usuarioDTO.Cell,
                //Id = id,
                Picture = picture,
                CoordinateId = coordinates.Id,
                DobId = dob.Id,
                LocationId = location.Id,
                LoginId = login.Id,
                NameId = name.Id,
                RegisteredId = registered.Id,
                PictureId = picture.Id,
                
                

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
