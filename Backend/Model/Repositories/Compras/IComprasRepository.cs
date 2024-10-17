using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Compras;

namespace Model.Repositories.Compras
{
    public interface IComprasRepository
    {
        // Aqui estarão todos os métodos que serão utilizados na Controller
        Task<IEnumerable<ListaDeCompras>> GetAllCompras();
        Task<ListaDeCompras?> GetComprasById(int id);
        Task AddCompra(ListaDeCompras compras);
        Task SaveChangesAsync();
    }

    public class ComprasRepository : IComprasRepository {
        private readonly TheHouseContext _context;
        public ComprasRepository(TheHouseContext context) {
            _context = context;
        }
        public async Task<IEnumerable<ListaDeCompras>> GetAllCompras()
        {
            return await _context.Compras.ToListAsync();
        }

        public async Task<ListaDeCompras?> GetComprasById(int id)
        {
            return await _context.Compras.FindAsync(id);
        }

        public async Task AddCompra(ListaDeCompras compras)
        {
            await _context.Compras.AddAsync(compras);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
