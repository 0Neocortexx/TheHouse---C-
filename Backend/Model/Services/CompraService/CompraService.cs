using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Compras;
using Model.Repositories.Compras;

namespace Model.Services.CompraService
{
    public class CompraService : IComprasRepository
    {
        private readonly TheHouseContext _context;
        public CompraService(TheHouseContext context)
        {
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
