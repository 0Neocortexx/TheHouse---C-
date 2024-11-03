using AutoMapper;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Entities.CompraEntity;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.Compras
{
    public class ListaCompraService : IListaCompraService
    {
        public readonly IListaCompraRepository _repository;
        public readonly IMapper _mapper;

        public ListaCompraService(IListaCompraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetListaCompraDto>?> GetAllListaCompra()
        {
            try
            {
                var compras = (await _repository.GetAllListaCompra()).ToList();

                if (compras == null)
                    return null;

                return _mapper.Map<List<GetListaCompraDto>>(compras);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task<GetListaCompraDto?> GetListaCompraById(int id) 
        {
            try
            {
                var compra = await _repository.GetListaCompraById(id);

                if (compra == null) 
                    return null;

                return _mapper.Map<GetListaCompraDto>(compra);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task AddListaCompra(CreateListaCompraDto listaCompra)
        {
            try
            {
                ListaCompra newListaCompra = _mapper.Map<ListaCompra>(listaCompra);

                await _repository.AddListaCompra(newListaCompra);

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
