using AutoMapper;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.Mapper
{
    public class MapperConfigureProfile : Profile
    {
        public MapperConfigureProfile() 
        { 
            CreateMap<UsuarioDTOCreate, Usuario>().ReverseMap();
            CreateMap<UsuarioDTO, Usuario>().ReverseMap();
            CreateMap<NameDTO, Name>().ReverseMap();
            CreateMap<LocationDTO, Location>().ReverseMap();
            CreateMap<LoginDTO, Login>().ReverseMap();
            CreateMap<DobDTO, Dob>().ReverseMap();
            CreateMap<RegisteredDTO, Registered>().ReverseMap();
            CreateMap<IdDTO, Id>().ReverseMap();
            CreateMap<PictureDTO, Picture>().ReverseMap();
        }
    }
}
