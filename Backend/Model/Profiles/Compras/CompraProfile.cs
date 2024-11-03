using AutoMapper;
using Model.DTOs.CompraDto.Mercado;
using Model.DTOs.DtosCompra.Compras;
using Model.DTOs.DtosCompra.ItemLista;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Entities.CompraEntities;
using Model.Entities.CompraEntity;
using System.Globalization;

namespace Model.Profiles.Compras
{
    public class CompraProfile : Profile
    {
        public CompraProfile() {

            CreateMap<Compra, GetCompraDto>()
                .ForMember(dest => dest.listaCompra, opt => opt.MapFrom(src => src.ListaCompra))
                .ForMember(prop => prop.Mercado, opt => opt.MapFrom(src => src.Mercado))
                .ForMember(prop => prop.DataCompra, opt => opt.MapFrom(src => src.DataCompra.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")))                
                .ReverseMap();

            CreateMap<CreateCompraDto, Compra>()
                .ForMember(dest => dest.DataCompra, opt => opt.MapFrom(src => DateTime.ParseExact(src.DataCompra, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToUniversalTime()))
                .ReverseMap();
            
            CreateMap<ListaCompra, GetListaCompraDto>()
                .ForMember(dest => dest.ItensListaCompra, opt => opt.MapFrom(src => src.ItensListaCompras))
                .ReverseMap();

            CreateMap<CreateListaCompraDto, ListaCompra>().ReverseMap();

            CreateMap<ItemListaCompra, GetItemListaCompraDto>().ReverseMap();

            CreateMap<CreateItemListaCompraDto, ItemListaCompra>().ReverseMap();

            CreateMap<CreateMercadoDto, Mercado>().ReverseMap();

            CreateMap<GetMercadoDto, Mercado>().ReverseMap();
        }
    }
}
