using Model.Entities.CompraEntity;

namespace Model.Repositories.Interfaces
{
    public interface IItemListaCompraRepository
    {
        public Task AddItemCompra(ItemListaCompra itemCompra);
        public Task<ItemListaCompra?> GetItemCompraById(int id);
        public Task<List<ItemListaCompra>?> GetAllItemCompra();
        public Task SaveChangesAsync();
    }
}
