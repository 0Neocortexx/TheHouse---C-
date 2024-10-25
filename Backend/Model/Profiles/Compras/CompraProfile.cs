using AutoMapper;
using Model.DTOs.Compras;
using Model.Entities.Compras;

namespace Model.Profiles.Compras
{
    public class CompraProfile : Profile
    {
        public CompraProfile() {
            CreateMap<ListaDeCompra, ComprasDto>().ReverseMap();
            CreateMap<CreateComprasDto, ListaDeCompra>().ReverseMap();
        }
    }
}
