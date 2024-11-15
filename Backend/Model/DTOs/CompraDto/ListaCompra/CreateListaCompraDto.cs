namespace Model.DTOs.DtosCompra.ListaCompra
{
    public class CreateListaCompraDto
    {
        public string? Nome { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime? DataCriacao { get; set; }
    }
}
