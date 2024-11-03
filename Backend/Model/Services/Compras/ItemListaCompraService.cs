using AutoMapper;
using Model.DTOs.DtosCompra.ItemLista;
using Model.Entities.CompraEntity;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.Compras
{
    public class ItemListaCompraService : IItemListaCompraService
    {
        private readonly IItemListaCompraRepository _repository;
        public readonly IMapper _mapper;
        public ItemListaCompraService(IItemListaCompraRepository compraRepository, IMapper mapper)
        {
            _repository = compraRepository;
            _mapper = mapper;
        }

        public async Task<List<GetItemListaCompraDto>?> GetAllItemCompra()
        {
            try
            {
                var compras = await _repository.GetAllItemCompra();

                if (compras == null)
                    return null;

                return _mapper.Map<List<GetItemListaCompraDto>>(compras);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<GetItemListaCompraDto?> GetItemCompraById(int id)
        {
            try
            {
                var compra = await _repository.GetItemCompraById(id);

                if (compra == null)
                    return null;

                return _mapper.Map<GetItemListaCompraDto>(compra);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task AddItemListaCompra(CreateItemListaCompraDto item)
        {
            try
            {
                var newCompra = _mapper.Map<ItemListaCompra>(item);

                await _repository.AddItemCompra(newCompra);

                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
