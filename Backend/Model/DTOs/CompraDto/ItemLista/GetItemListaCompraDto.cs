namespace Model.DTOs.DtosCompra.ItemLista
{
    public class GetItemListaCompraDto
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Quantidade { get; set; }
        public string? ValorMedioUnitario { get; set; }
        public string? ValorTotal { get; set; }
        public int? ListaCompraId { get; set; }
    }
}
