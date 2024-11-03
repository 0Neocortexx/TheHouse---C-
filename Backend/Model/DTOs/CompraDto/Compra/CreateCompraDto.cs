
using Model.Enums.Compras;

namespace Model.DTOs.DtosCompra.Compras
{
    public class CreateCompraDto
    {
        public string? LinkNota { get; set; }
        public string? ValorPago { get; set; }
        public string? DataCompra { get; set; }
        public EStatusCompra? Status { get; set; }
        public int? UsuarioId { get; set; }
        public int? ListaCompraId { get; set; }
        public int? MercadoId { get; set; }
    }
}
