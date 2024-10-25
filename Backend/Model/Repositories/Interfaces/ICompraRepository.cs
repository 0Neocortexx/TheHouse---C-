using Model.Entities.Compras;
using Model.Entities.GrupoMeta;

namespace Model.Repositories.Interfaces
{
     public interface ICompraRepository
    {
        public Task AddCompra(ListaDeCompra compra);
        public Task<ListaDeCompra?> GetCompraById(int id);
        public Task<IEnumerable<ListaDeCompra>> GetAllCompras();
        public Task SaveChangesAsync();
    }
}
