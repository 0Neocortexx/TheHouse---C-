using AutoMapper;
using Model.DTOs.MetaDto;
using Model.Entities.GrupoMeta;

namespace Model.Profiles.MetaProfile
{
    public class MetaProfile : Profile
    {
        public MetaProfile() 
        {
            CreateMap<Meta, MetaDto>().ReverseMap(); // Mapeamento de Meta para MetaDto
            CreateMap<CreateMetaDto, Meta>().ReverseMap();
        }
    }
}
