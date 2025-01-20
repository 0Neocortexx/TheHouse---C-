using AutoMapper;
using Model.DTOs.Compras.Mercado;
using Model.DTOs.Compras.Compra;
using Model.DTOs.Compras.ItemLista;
using Model.DTOs.Compras.ListaCompra;
using Model.Entities.Compras;
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
                .ForMember(prop => prop.DataCriacao, opt => opt.MapFrom(src => src.DataCriacao.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")))
                .ReverseMap();

            CreateMap<CreateListaCompraDto, ListaCompra>()
                .ForMember(prop => prop.DataCriacao, opt => opt.MapFrom(src => src.DataCriacao.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")))
                .ReverseMap();

            CreateMap<ItemListaCompra, GetItemListaCompraDto>().ReverseMap();

            CreateMap<CreateItemListaCompraDto, ItemListaCompra>().ReverseMap();

            CreateMap<CreateMercadoDto, Mercado>().ReverseMap();

            CreateMap<GetMercadoDto, Mercado>().ReverseMap();
        }
    }
}
