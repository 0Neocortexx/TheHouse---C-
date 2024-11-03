using AutoMapper;
using Model.DTOs.DtosCompra.Compras;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Entities.CompraEntity;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.Compras
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _repository;
        private readonly IListaCompraRepository _listaRepository;
        public readonly IMapper _mapper;

        public CompraService(ICompraRepository compraRepository, IListaCompraRepository listarepository, IMapper mapper)
        {
            _repository = compraRepository;
            _mapper = mapper;
            _listaRepository = listarepository;
        }

        public async Task<List<GetCompraDto>?> GetAllCompras()
        {
            try
            {
                var compras = await _repository.GetAllCompras();

                if (compras == null)
                    return null;

                return _mapper.Map<List<GetCompraDto>>(compras);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<GetCompraDto?> GetCompraById(int id)
        {
            try
            {
                var compra = await _repository.GetCompraById(id);

                if (compra == null)
                    return null;

                return _mapper.Map<GetCompraDto>(compra);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task AddCompra(CreateCompraDto compras)
        {
            try
            {
                var newCompra = _mapper.Map<Compra>(compras);

                await _repository.AddCompra(newCompra);

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
