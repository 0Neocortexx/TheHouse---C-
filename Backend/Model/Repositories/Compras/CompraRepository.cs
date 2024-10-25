using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Compras;
using Model.Repositories.Interfaces;

namespace Model.Repositories.Compras
{
    public class CompraRepository : ICompraRepository
    {
        public readonly TheHouseContext _context;

        public CompraRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task AddCompra(ListaDeCompra compra)
        {
            await _context.AddAsync(compra);
        }

        public async Task<ListaDeCompra?> GetCompraById(int id)
        {
            return await _context.Compras.FindAsync(id);
        }

        public async Task<IEnumerable<ListaDeCompra>> GetAllCompras()
        {
            return await _context.Compras.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }   
}
