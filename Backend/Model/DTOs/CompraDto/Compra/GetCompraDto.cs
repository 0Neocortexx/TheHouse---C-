using Model.DTOs.CompraDto.Mercado;
using Model.DTOs.DtosCompra.ListaCompra;

namespace Model.DTOs.DtosCompra.Compras
{
    public class GetCompraDto
    {
        public int? Id { get; set; }
        public string? LinkNota { get; set; }
        public string? ValorPago { get; set; }
        public string? DataCompra { get; set; }
        public Guid? UsuarioId { get; set; }
        public GetMercadoDto? Mercado { get; set; }
        public GetListaCompraDto? listaCompra { get; set; }
    }
}
