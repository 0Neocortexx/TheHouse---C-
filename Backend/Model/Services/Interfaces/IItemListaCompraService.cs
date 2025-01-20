using Model.DTOs.Compras.ItemLista;

namespace Model.Services.Interfaces
{
    public interface IItemListaCompraService
    {
        public Task<List<GetItemListaCompraDto>?> GetAllItemCompra();
        public Task<GetItemListaCompraDto?> GetItemCompraById(int id);
        public Task AddItemListaCompra(CreateItemListaCompraDto item);
    }
}
