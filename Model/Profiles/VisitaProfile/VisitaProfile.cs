using AutoMapper;
using Dtos.VisitaDto;
using Model.Entities.Visita;

namespace Model.Profiles.VisitaProfile
{
    public class VisitaProfile : Profile {
        public VisitaProfile() {

            CreateMap<Visita, VisitaDto>();
            //  .ForMember(prop => prop.DataVisita,src => src.MapFrom(opt => DateTime.Parse(opt.DataVisita)));
            // CreateMap<VisitasDto,Visitas>();
            CreateMap<VisitaDto, Visita>();

        }
    }
}
