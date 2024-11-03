using Model.DTOs.DtosCompra.ListaCompra;

namespace Model.Services.Interfaces
{
    public interface IListaCompraService
    {
        public Task<List<GetListaCompraDto>?> GetAllListaCompra();
        public Task<GetListaCompraDto?> GetListaCompraById(int id);
        public Task AddListaCompra(CreateListaCompraDto listaCompra);
    }
}
