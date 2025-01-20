using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Compras;
using Model.Repositories.Interfaces;

namespace Model.Repositories.Compras
{
    public class MercadoRepository : IMercadoRepository
    {
        public readonly TheHouseContext _context;

        public MercadoRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task AddMercado(Mercado mercado)
        {
            await _context.Mercado.AddAsync(mercado);
        }

        public async Task<Mercado?> GetMercadoById(int id)
        {
            return await _context.Mercado.FindAsync(id);
        }

        public async Task<List<Mercado>> GetAllMercado()
        {
            return await _context.Mercado.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
