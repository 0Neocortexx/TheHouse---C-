using AutoMapper;
using Model.DTOs.DtosCompra.Compras;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Entities.CompraEntity;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.ComprasService
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _repository;
        public readonly IMapper _mapper;
        public CompraService(ICompraRepository compraRepository, IMapper mapper)
        {
            _repository = compraRepository;
            _mapper = mapper;
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

        public async Task<List<GetCompraDto>> GetAllComprasByUserId(Guid? userId)
        {
            List<Compra> lista = await _repository.GetAllComprasByUserId(userId);

            return _mapper.Map<List<GetCompraDto>>(lista);
        }
    }
}
