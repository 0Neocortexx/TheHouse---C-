using Model.DTOs.DtosCompra.ItemLista;
using Model.Entities.CompraEntity;

namespace Model.DTOs.DtosCompra.ListaCompra
{
    public class GetListaCompraDto
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public List<GetItemListaCompraDto>? ItensListaCompra { get; set; }
        public string? ValorTotalEspeculado { get; set; }
    }
}
