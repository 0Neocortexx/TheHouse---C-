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

        public async Task<List<GetListaCompraDto>?> GetListaComprasByUserId(Guid userId)
        {
            var lista = (await _repository.GetListaComprasByUserId(userId)).ToList();

            if (lista == null)
                return null;

            return _mapper.Map<List<GetListaCompraDto>>(lista);
             
        } 

        public async Task<List<GetListaCompraDto>?> GetAllListaCompra()
        {

            var compras = (await _repository.GetAllListaCompra()).ToList();

            if (compras == null)
                return null;

            return _mapper.Map<List<GetListaCompraDto>>(compras);
        }
        public async Task<GetListaCompraDto?> GetListaCompraById(int id) 
        {
            var compra = await _repository.GetListaCompraById(id);

            if (compra == null) 
               return null;

            return _mapper.Map<GetListaCompraDto>(compra);
        }

        public async Task AddListaCompra(CreateListaCompraDto listaCompra)
        {

            ListaCompra newListaCompra = _mapper.Map<ListaCompra>(listaCompra);

            await _repository.AddListaCompra(newListaCompra);

            await _repository.SaveChangesAsync();

        }

        public async Task RemoveListaCompra(int id)
        {
            _repository.RemoveListaCompra(id);
            await _repository.SaveChangesAsync();
        }
    }
}
