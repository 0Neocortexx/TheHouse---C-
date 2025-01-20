using AutoMapper;
using Model.DTOs.Metas;
using Model.Entities.Metas;

namespace Model.Profiles.Metas
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
