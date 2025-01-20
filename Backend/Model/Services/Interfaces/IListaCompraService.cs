using Model.DTOs.Compras.ListaCompra;

namespace Model.Services.Interfaces
{
    public interface IListaCompraService
    {
        public Task<List<GetListaCompraDto>?> GetAllListaCompra();
        public Task<GetListaCompraDto?> GetListaCompraById(int id);
        public Task AddListaCompra(CreateListaCompraDto listaCompra);
        public Task<List<GetListaCompraDto>?> GetListaComprasByUserId(Guid userId);
        public Task RemoveListaCompra(int id);
    }
}
