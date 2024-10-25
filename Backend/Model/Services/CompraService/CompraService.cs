using Model.Entities.Compras;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.CompraService
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        public CompraService(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }
        public async Task<List<ListaDeCompra>> GetAllCompras()
        {
            return (await _compraRepository.GetAllCompras()).ToList();
        }

        public async Task<ListaDeCompra?> GetCompraById(int id)
        {
            return await _compraRepository.GetCompraById(id);
        }

        public async Task AddCompra(ListaDeCompra compras)
        {
            await _compraRepository.AddCompra(compras);
        }

        public async Task SaveChangesAsync()
        {
            await _compraRepository.SaveChangesAsync();
        }

    }
}
