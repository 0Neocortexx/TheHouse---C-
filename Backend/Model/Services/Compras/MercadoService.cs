using AutoMapper;
using Model.DTOs.CompraDto.Mercado;
using Model.Entities.CompraEntities;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.Compras
{
    public class MercadoService : IMercadoService
    {
        public readonly IMercadoRepository _repository;
        public readonly IMapper _mapper;

        public MercadoService(IMercadoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetMercadoDto>?> GetAllMercado()
        {
            try
            {
                var compras = (await _repository.GetAllMercado()).ToList();

                if (compras == null)
                    return null;

                return _mapper.Map<List<GetMercadoDto>>(compras);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task<GetMercadoDto?> GetMercadoById(int id)
        {
            try
            {
                var compra = await _repository.GetMercadoById(id);

                if (compra == null)
                    return null;

                return _mapper.Map<GetMercadoDto>(compra);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task AddMercado(CreateMercadoDto mercado)
        {
            try
            {
                Mercado newMercado = _mapper.Map<Mercado>(mercado);

                await _repository.AddMercado(newMercado);

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
