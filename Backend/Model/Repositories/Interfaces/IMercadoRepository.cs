using Model.Entities.Compras;

namespace Model.Repositories.Interfaces
{
    public interface IMercadoRepository
    {
        public Task AddMercado(Mercado mercado);
        public Task<Mercado?> GetMercadoById(int id);
        public Task<List<Mercado>> GetAllMercado();
        public Task SaveChangesAsync();
    }
}
