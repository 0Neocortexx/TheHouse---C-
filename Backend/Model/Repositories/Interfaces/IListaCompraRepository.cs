using Model.Entities.Compras;

namespace Model.Repositories.Interfaces
{
    public interface IListaCompraRepository
    {
        public Task AddListaCompra(ListaCompra listaCompra);
        public Task<ListaCompra?> GetListaCompraById(int id);
        public Task<List<ListaCompra>> GetAllListaCompra();
        public void RemoveListaCompra(int id);
        public Task<List<ListaCompra>> GetListaComprasByUserId(Guid userId);
        public Task SaveChangesAsync();
    }
}
