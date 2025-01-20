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

        public async Task AddCompra(Compra compra)
        {
            await _context.Compra.AddAsync(compra);
        }

        public async Task<Compra?> GetCompraById(int id)
        {
            // Inclui a ListaCompra e os ItensListaCompra ao buscar por uma Compra específica
            return await _context.Compra
                .Include(c => c.ListaCompra) // Indica que ao consultar a entidade Compra a propriedade de navegação ListaCompra associada deve ser carregada junto com ela.
                .ThenInclude(l => l.ItensListaCompras) // Indica que ao realizar a consulta de lista de compra o entity framework deve realizar a consulta de itens vinculada a ela
                .Include(m => m.Mercado) // Consulta a entidade mercado associada
                .FirstOrDefaultAsync(c => c.Id == id); // Método assincrono que procura o primeiro registro que corresponda ao critério, caso não encontre retorna null
                // Na expressão lambda, C corresponde a compra, ou seja, irá procurar um registro que seja igual ao id passado no método GetCompraById
        }

        public async Task<List<Compra>> GetAllCompras()
        {
            // Inclui a ListaCompra e os ItensListaCompra ao buscar todas as Compras
            return await _context.Compra
                .Include(c => c.ListaCompra) // Indica que o EF ao consultar a entidade Compra a propriedade de navegação ListaCompra deve ser carregada junto
                .ThenInclude(l => l.ItensListaCompras) // Deve carregar os itens da lista de compra vinculada a lista de compra
                .Include(m => m.Mercado) // Consulta a entidade mercado associada
                .ToListAsync(); // retorna em formato de lista
        }

        public async Task<List<Compra>> GetAllComprasByUserId(Guid? userId)
        {
            return await _context.Compra
                .Include(c => c.ListaCompra)
                .ThenInclude(l => l.ItensListaCompras)
                .Include(m => m.Mercado)
                .Where(c => c.UsuarioId == userId)
                .ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }   
}
