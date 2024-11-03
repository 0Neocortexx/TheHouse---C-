using Model.Entities.CompraEntity;

namespace Model.Repositories.Interfaces
{
    public interface IListaCompraRepository
    {
        public Task AddListaCompra(ListaCompra listaCompra);
        public Task<ListaCompra?> GetListaCompraById(int id);
        public Task<List<ListaCompra>> GetAllListaCompra();
        public Task SaveChangesAsync();
    }
}
