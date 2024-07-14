using AutoMapper;
using Dtos.Visitas;
using Model.Entities.Entretenimento;

namespace Model.Profiles.Entretenimento {
    public class VisitasProfile : Profile {
        public VisitasProfile() {
            CreateMap<Visitas,VisitasDto>();
            CreateMap<VisitasDto,Visitas>();
        }
    }
}
