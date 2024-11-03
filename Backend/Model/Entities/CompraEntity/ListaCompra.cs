namespace Model.Entities.CompraEntity
{
    public class ListaCompra
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        
        // Navegação ItemListaCompra
        public List<ItemListaCompra>? ItensListaCompras { get; set; }

        // Somará o valor de todos os itens da tabela ItensListaCompras
        public decimal? ValorTotalEspeculado { get => ItensListaCompras != null ? ItensListaCompras.Sum(item => item.ValorTotal) : 0; } // Não será um campo da tabela

        public ListaCompra() { }

        public ListaCompra(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
