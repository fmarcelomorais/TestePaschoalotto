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
        }
    }
}
