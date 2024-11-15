using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.CompraEntity;
using Model.Repositories.Interfaces;

namespace Model.Repositories.Compras
{
    public class ListaCompraRepository : IListaCompraRepository
    {
        public readonly TheHouseContext _context;

        public ListaCompraRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task AddListaCompra(ListaCompra lista)
        {
            await _context.ListaCompra.AddAsync(lista);
        }

        public async Task<ListaCompra?> GetListaCompraById(int id)
        {
            return await _context.ListaCompra 
                .Include(i => i.ItensListaCompras) // Inclui os itens da lista de compra
                .FirstOrDefaultAsync(l => l.Id == id); // Procura o primeiro registro com o id passado como parâmetro, caso contrario retorna null
        }

        public async Task<List<ListaCompra>> GetListaComprasByUserId(Guid userId)
        {
            return await _context.ListaCompra
                .Include(i => i.ItensListaCompras)
                .Where(u => u.UsuarioId == userId)
                .ToListAsync();
        }

        public async Task<List<ListaCompra>> GetAllListaCompra()
        {
            return await _context.ListaCompra
                .Include(i => i.ItensListaCompras) // Inclui os itens da lista de compra
                .ToListAsync(); // Retorna a lista
        }

        public void RemoveListaCompra(int id)
        {
            var listacompra = _context.ListaCompra
                                   .Where(l => l.Id == id)
                                   .FirstOrDefault();
            if(listacompra != null)
                _context.Remove(listacompra);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
