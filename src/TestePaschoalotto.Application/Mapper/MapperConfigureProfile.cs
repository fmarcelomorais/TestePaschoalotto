using AutoMapper;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.Mapper
{
    public class MapperConfigureProfile : Profile
    {
        public MapperConfigureProfile() 
        { 
            CreateMap<UsuarioDTO, Usuario>().ReverseMap();
        }
    }
}
