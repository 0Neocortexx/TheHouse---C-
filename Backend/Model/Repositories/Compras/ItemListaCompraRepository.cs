using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.CompraEntity;
using Model.Repositories.Interfaces;

namespace Model.Repositories.Compras
{
    public class ItemListaCompraRepository : IItemListaCompraRepository
    {
        public readonly TheHouseContext _context;

        public ItemListaCompraRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task AddItemCompra(ItemListaCompra item)
        {
            await _context.ItemListaCompras.AddAsync(item);
        } 

        public async Task<ItemListaCompra?> GetItemCompraById(int id)
        {
            return await _context.ItemListaCompras.FindAsync(id);
        }

        public async Task<List<ItemListaCompra>?> GetAllItemCompra()
        {
            return await _context.ItemListaCompras.ToListAsync();
        }

        public async Task SaveChangesAsync() 
        {
            await _context.SaveChangesAsync();
        }
    }
}
