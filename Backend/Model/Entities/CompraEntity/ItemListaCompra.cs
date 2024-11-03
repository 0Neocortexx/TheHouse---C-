namespace Model.Entities.CompraEntity
{
    public class ItemListaCompra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Quantidade { get; set; }
        public decimal? ValorMedioUnitario { get; set; }
        public decimal? ValorTotal { get => Quantidade * ValorMedioUnitario.Value; } // Não será um campo da tabela - Apenas retornará um valor calculado :D

        // Referencia a tabela ListaCompra
        public ListaCompra? ListaCompra { get; set; }
        public int ListaCompraId { get; set; }

        public ItemListaCompra() { }

        public ItemListaCompra(int id, string nome, int quantidade, decimal valorMedioUnitario, ListaCompra listaCompra)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            ValorMedioUnitario = valorMedioUnitario;
            ListaCompra = listaCompra;
        }

    }
}
