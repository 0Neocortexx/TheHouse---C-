using Model.Entities.Compras;

namespace Model.Services.Interfaces
{
    public interface ICompraService
    {
        public Task<List<ListaDeCompra>> GetAllCompras();
        public Task<ListaDeCompra?> GetCompraById(int id);
        public Task AddCompra(ListaDeCompra compras);
        public Task SaveChangesAsync();
    }
}
