using AutoMapper;
using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();

            CreateMap<Villa, NumeroVillaDto>().ReverseMap();
            CreateMap<Villa, NumeroVillaCreateDto>().ReverseMap();
            CreateMap<Villa, NumeroVillaUpdateDto>().ReverseMap();



        }
    }
}
