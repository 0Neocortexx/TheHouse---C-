using Model.DTOs.DtosCompra.ItemLista;

namespace Model.DTOs.DtosCompra.ListaCompra
{
    public class GetListaCompraDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public List<GetItemListaCompraDto>? ItensListaCompra { get; set; }
        public string? ValorTotalEspeculado { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Guid? UsuarioId { get; set; }
    }
}
