using AutoMapper;
using Model.DTOs.Compras;
using Model.Entities.Compras;

namespace Model.Profiles.Compras
{
    public class ComprasProfile : Profile
    {
        public ComprasProfile() {
            CreateMap<ListaDeCompras, ComprasDto>();
            CreateMap<ComprasDto, ListaDeCompras>();
        }
    }
}
