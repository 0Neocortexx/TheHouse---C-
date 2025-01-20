namespace Model.DTOs.Compras.ItemLista
{
    public class CreateItemListaCompraDto
    {
        public string? Nome { get; set; }
        public string? Quantidade { get; set; }
        public string? ValorMedioUnitario { get; set; }
        public int? ListaCompraId { get; set; }
    }
}
