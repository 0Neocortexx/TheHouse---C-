using Model.DTOs.Compras.Mercado;

namespace Model.Services.Interfaces
{
    public interface IMercadoService
    {
        public Task<List<GetMercadoDto>?> GetAllMercado();
        public Task<GetMercadoDto?> GetMercadoById(int id);
        public Task AddMercado(CreateMercadoDto mercado);
    }
}
