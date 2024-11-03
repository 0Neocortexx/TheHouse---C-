using Model.Entities.CompraEntity;

namespace Model.Repositories.Interfaces
{
    public interface ICompraRepository
    {
        public Task AddCompra(Compra compra);
        public Task<Compra?> GetCompraById(int id);
        public Task<List<Compra>> GetAllCompras();
        public Task SaveChangesAsync();
    }
}
