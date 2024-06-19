using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Application.Interface;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUserRepository _userRepository;
        private readonly IContactRepository _contactRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly ILoginRepository _loginRepository;
        private readonly INaturalizationRepository _naturalizationRepository;
        private readonly IPictureRepository _pictureRepository;
        public UsuarioService(IUserRepository userRepository, 
            IContactRepository contaRepository, ILocationRepository locationRepository,
            ILoginRepository loginRepository, INaturalizationRepository naturalizationRepository, IPictureRepository pictureRepository)
        {
            _userRepository = userRepository;
            _contactRepository = contaRepository;
            _locationRepository = locationRepository;
            _loginRepository = loginRepository;
            _pictureRepository = pictureRepository;
            _naturalizationRepository = naturalizationRepository;
        }
        public async Task CadastraUsuario(UsuarioDTOCreate usuarioDTO)
        {
            var contact = new Contact
            {
                Phone = usuarioDTO.Phone,
                Cell =  usuarioDTO.Cell,
                Name =  usuarioDTO.Name,
                Value = usuarioDTO.Value
            };

            var login = new Login
            {
                Email = usuarioDTO.Email,
                Uuid = usuarioDTO.Uuid,
                UserName = usuarioDTO.UserName,
                Password = usuarioDTO.Password,
                Salt = usuarioDTO.Salt,
                Md5 = usuarioDTO.Md5,
                Sha1 = usuarioDTO.Sha1,
                Sha256  = usuarioDTO.Sha256,
                AgeLogin = usuarioDTO.AgeLogin,
            };

            var location = new Location
            {
                Name = usuarioDTO.Name,
                Number = usuarioDTO.Number,
                City = usuarioDTO.City,
                State = usuarioDTO.State,
                Country = usuarioDTO.Country,
                PostCode = usuarioDTO.PostCode,
                Latitude = usuarioDTO.Latitude,
                Longitude = usuarioDTO.Longitude,
                OffSet = usuarioDTO.OffSet,
                Description = usuarioDTO.Description
            };

            var naturalization = new Naturalization
            {
                Nat = usuarioDTO.Nat
            };

            var picture = new Picture
            {
                Large = usuarioDTO.Large,
                Medium = usuarioDTO.Medium,
                Thumbnail = usuarioDTO.Thumbnail,
            };

            var user = new User
            {
                Title = usuarioDTO.Title,
                FirstName = usuarioDTO.FirstName,
                LastName = usuarioDTO.LastName,
                Gender = usuarioDTO.Gender,
                DateUser = usuarioDTO.DateUser,
                Age = usuarioDTO.Age,

                LoginId = login.Id,
                ContactId = contact.Id,
                LocationId = location.Id,
                NaturalizationId = naturalization.Id,
                PictureId = picture.Id,                
            };

            await _pictureRepository.Create(picture);
            await _naturalizationRepository.Create(naturalization);
            await _loginRepository.Create(login);
            await _locationRepository.Create(location);
            await _contactRepository.Create(contact);
            await _userRepository.Create(user);
        }

        public Task EditarUsuario(UsuarioDTOCreate usuarioDTOCreate)
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
