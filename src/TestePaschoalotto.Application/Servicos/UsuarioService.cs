using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Application.Interface;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;
using TestePaschoalotto.Domain.ValueObjects;

namespace TestePaschoalotto.Application.Servicos;

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
        var id = _mapper.Map<Identity>(usuarioDTO.Id);


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
            Identity = id,
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

    public async Task EditarUsuario(UsuarioDTO usuarioDTO)
    {
        var usuario = MapeiaUsuarioDTOaraUsuario(usuarioDTO);
        await _userRepository.Update(usuario);
    }

    public async Task<UsuarioDTO> ObterUsuario(string filtro)
    {
        var usuario = await _userRepository.Find(u => u.Login.Username == filtro);
        return MapeiaUsuarioParaUsuarioDTO(usuario);
    }

    public async Task<List<UsuarioDTO>> ObterUsuarios()
    {

        var usuarios = await _userRepository.GetAll();
        return MapeiaListaUsuario(usuarios);           
        
     }
    private List<UsuarioDTO> MapeiaListaUsuario(List<Usuario> usuarios)
    {
        List<UsuarioDTO> lista = new List<UsuarioDTO>();
        foreach (var item in usuarios)
        {
            var name = _mapper.Map<NameDTO>(item.Name);
            var login = _mapper.Map<LoginDTO>(item.Login);
            var dob = _mapper.Map<DobDTO>(item.Dob);
            var registered = _mapper.Map<RegisteredDTO>(item.Registered);
            var identity = _mapper.Map<IdDTO>(item.Identity);


            var street = new StreetDTO
            {
                Number = item.Location.Street.Number,
                Name = item.Location.Street.Name,
            };
            var coordinates = new CoordinatesDTO
            {
                Latitude = item.Location.Coordinates.Latitude,
                Longitude = item.Location.Coordinates.Longitude,
            };
            var timezone = new TimezoneDTO
            {
                Offset = item.Location.Timezone.Offset,
                Description = item.Location.Timezone.Description,
            };
            var location = new LocationDTO
            {
                City = item.Location.City,
                State = item.Location.State,
                Country = item.Location.Country,
                Postcode = item.Location.Postcode,
                Street = street,
                Coordinates = coordinates,
                Timezone = timezone

            };
            var picture = _mapper.Map<PictureDTO>(item.Picture);

            var usuario = new UsuarioDTO
            {
                Gender = item.Gender,
                Name = name,
                Location = location,
                Email = item.Email,
                Login = login,
                Dob = dob,
                Registered = registered,
                Phone = item.Phone,
                Cell = item.Cell,
                Id = identity,
                Picture = picture
            };
        
            lista.Add(usuario);
        }

        return lista;
    }

    private UsuarioDTO MapeiaUsuarioParaUsuarioDTO(Usuario usuario)
    {
        var name = _mapper.Map<NameDTO>(usuario.Name);
        var login = _mapper.Map<LoginDTO>(usuario.Login);
        var dob = _mapper.Map<DobDTO>(usuario.Dob);
        var registered = _mapper.Map<RegisteredDTO>(usuario.Registered);
        var id = _mapper.Map<IdDTO>(usuario.Identity);


        var street = new StreetDTO
        {
            Number = usuario.Location.Street.Number,
            Name = usuario.Location.Street.Name,
        };
        var coordinates = new CoordinatesDTO
        {
            Latitude = usuario.Location.Coordinates.Latitude,
            Longitude = usuario.Location.Coordinates.Longitude,
        };
        var timezone = new TimezoneDTO
        {
            Offset = usuario.Location.Timezone.Offset,
            Description = usuario.Location.Timezone.Description,
        };
        var location = new LocationDTO
        {
            City = usuario.Location.City,
            State = usuario.Location.State,
            Country = usuario.Location.Country,
            Postcode = usuario.Location.Postcode,
            Street = street,
            Coordinates = coordinates,
            Timezone = timezone

        };
        var picture = _mapper.Map<PictureDTO>(usuario.Picture);

        var usuarioMapeado = new UsuarioDTO
        {
            Gender = usuario.Gender,
            Name = name,
            Location = location,
            Email = usuario.Email,
            Login = login,
            Dob = dob,
            Registered = registered,
            Phone = usuario.Phone,
            Cell = usuario.Cell,
            Id = id,
            Picture = picture,
            //CoordinateId = coordinates.Id,
            //DobId = dob.Id,
            //LocationId = location.Id,
            //LoginId = login.Id,
            //NameId = name.Id,
            //RegisteredId = registered.Id,
            //PictureId = picture.Id,

        };

        return usuarioMapeado;
    }

    private Usuario MapeiaUsuarioDTOaraUsuario(UsuarioDTO usuario)
    {
        var name = _mapper.Map<Name>(usuario.Name);
        var login = _mapper.Map<Login>(usuario.Login);
        var dob = _mapper.Map<Dob>(usuario.Dob);
        var registered = _mapper.Map<Registered>(usuario.Registered);
        var id = _mapper.Map<Identity>(usuario.Id);


        var street = new Street
        {
            Number = usuario.Location.Street.Number,
            Name = usuario.Location.Street.Name,
        };
        var coordinates = new Coordinates
        {
            Latitude = usuario.Location.Coordinates.Latitude,
            Longitude = usuario.Location.Coordinates.Longitude,
        };
        var timezone = new Timezone
        {
            Offset = usuario.Location.Timezone.Offset,
            Description = usuario.Location.Timezone.Description,
        };
        var location = new Location
        {
            City = usuario.Location.City,
            State = usuario.Location.State,
            Country = usuario.Location.Country,
            Postcode = usuario.Location.Postcode,
            Street = street,
            Coordinates = coordinates,
            Timezone = timezone

        };
        var picture = _mapper.Map<Picture>(usuario.Picture);

        var usuarioMapeado = new Usuario
        {
            Gender = usuario.Gender,
            Name = name,
            Location = location,
            Email = usuario.Email,
            Login = login,
            Dob = dob,
            Registered = registered,
            Phone = usuario.Phone,
            Cell = usuario.Cell,
            Identity = id,
            Picture = picture,
            //CoordinateId = coordinates.Id,
            //DobId = dob.Id,
            //LocationId = location.Id,
            //LoginId = login.Id,
            //NameId = name.Id,
            //RegisteredId = registered.Id,
            //PictureId = picture.Id,

        };

        return usuarioMapeado;
    }

}
