using Model.DTOs.CompraDto.Mercado;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Enums.Compras;

namespace Model.DTOs.DtosCompra.Compras
{
    public class GetCompraDto
    {
        public int? Id { get; set; }
        public string? LinkNota { get; set; }
        public string? ValorPago { get; set; }
        public string? DataCompra { get; set; }
        public EStatusCompra? Status { get; set; }
        public int? UsuarioId { get; set; }
        public GetMercadoDto? Mercado { get; set; }
        public GetListaCompraDto? listaCompra { get; set; }
    }
}
