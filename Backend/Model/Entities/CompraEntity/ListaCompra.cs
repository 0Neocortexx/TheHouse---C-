using Model.Entities.GrupoUsuario;

namespace Model.Entities.CompraEntity
{
    public class ListaCompra
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        
        // Navegação ItemListaCompra
        public List<ItemListaCompra>? ItensListaCompras { get; set; }

        public DateTime? DataCriacao { get; set; }

        // Somará o valor de todos os itens da tabela ItensListaCompras
        public decimal? ValorTotalEspeculado { get => ItensListaCompras != null ? ItensListaCompras.Sum(item => item.ValorTotal) : 0; } // Não será um campo da tabela

        // Referencia da tabela usuario
        public Usuario? Usuario { get; set; } // Define a navegação de usuario
        public Guid UsuarioId { get; set; }

        public ListaCompra() { }

        public ListaCompra(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
