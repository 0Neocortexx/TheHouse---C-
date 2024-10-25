using AutoMapper;
using Model.DTOs.MetaDto;
using Model.Entities.GrupoMeta;

namespace Model.Profiles.MetaProfile
{
    public class MetaProfile : Profile
    {
        public MetaProfile() 
        {
            CreateMap<Meta, MetaDto>(); // Mapeamento de Meta para MetaDto
            CreateMap<MetaDto, Meta>(); // Mapeamento de MetaDto para Meta
            CreateMap<CreateMetaDto, Meta>();
            CreateMap<List<Meta>, List<MetaDto>>();
            CreateMap<List<MetaDto>, List<Meta>>();
        }
    }
}
