using AutoMapper;
using Dtos.Visitas;
using Model.Entities.Entretenimento;

namespace Model.Profiles.Entretenimento {
    public class VisitasProfile : Profile {
        public VisitasProfile() {

            CreateMap<Visitas, VisitasDto>();
              //  .ForMember(prop => prop.DataVisita,src => src.MapFrom(opt => DateTime.Parse(opt.DataVisita)));
            // CreateMap<VisitasDto,Visitas>();

        }
    }
}
