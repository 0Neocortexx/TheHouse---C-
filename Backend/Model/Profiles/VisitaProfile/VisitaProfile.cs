using AutoMapper;
using Dtos.VisitaDto;
using Model.Entities.Visita;

namespace Model.Profiles.VisitaProfile
{
    public class VisitaProfile : Profile {
        public VisitaProfile() {
            CreateMap<Visita, VisitaDto>()
                .ReverseMap();
            CreateMap<CreateVisitaDto, Visita>()
                .ReverseMap();
        }
    }
}
