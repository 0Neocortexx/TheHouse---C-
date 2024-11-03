using Model.Entities.CompraEntities;
using Model.Entities.GrupoUsuario;
using Model.Enums.Compras;

namespace Model.Entities.CompraEntity
{
    public class Compra {
        public int Id { get; set; }
        public string? LinkNota { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime? DataCompra { get; set; }
        public EStatusCompra Status { get; set; } 

        // Referencia da tabela Lista de compra
        public ListaCompra? ListaCompra { get; set; } // Define a navegação de ListaCompra
        public int ListaCompraId { get; set; }

        // Referencia da tabela usuario
        public Usuario? Usuario { get; set; } // Define a navegação de usuario
        public int UsuarioId { get; set; }

        // Referencia da Tabela Mercado
        public Mercado? Mercado { get; set; } // Define a navegação de mercado
        public int MercadoId { get; set; }
        

        public Compra() {
        }

        public Compra(int id, string linkNota, decimal valorPago, DateTime? dataCompra, EStatusCompra status, Mercado mercado, ListaCompra listaCompra, Usuario usuario)
        {
            Id = id;
            LinkNota = linkNota;
            ValorPago = valorPago;
            DataCompra = dataCompra;
            Status = status;
            Mercado = mercado;
            ListaCompra = listaCompra;
            Usuario = usuario;
        }
    }
}
