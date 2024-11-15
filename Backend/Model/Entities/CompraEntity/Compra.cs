using Model.Entities.CompraEntities;
using Model.Entities.GrupoUsuario;

namespace Model.Entities.CompraEntity
{
    public class Compra {
        public int Id { get; set; }
        public string? LinkNota { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime? DataCompra { get; set; }

        // Referencia da tabela Lista de compra
        public ListaCompra? ListaCompra { get; set; } // Define a navegação de ListaCompra
        public int? ListaCompraId { get; set; }

        // Referencia da tabela usuario
        public Usuario? Usuario { get; set; } // Define a navegação de usuario
        public Guid UsuarioId { get; set; }

        // Referencia da Tabela Mercado
        public Mercado? Mercado { get; set; } // Define a navegação de mercado
        public int? MercadoId { get; set; }
        

        public Compra() {
        }

        public Compra(int id, string linkNota, decimal valorPago, DateTime? dataCompra, Mercado mercado, ListaCompra listaCompra, Usuario usuario)
        {
            Id = id;
            LinkNota = linkNota;
            ValorPago = valorPago;
            DataCompra = dataCompra;
            Mercado = mercado;
            ListaCompra = listaCompra;
            Usuario = usuario;
        }
    }
}
