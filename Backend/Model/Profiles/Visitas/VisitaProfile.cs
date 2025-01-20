using AutoMapper;
using DTOs.Visitas;
using Model.Entities.Visitas;

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
