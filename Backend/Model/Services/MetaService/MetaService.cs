using Model.Repositories.MetaRepository;
using Model.Entities.GrupoMeta;
using Microsoft.EntityFrameworkCore;

namespace Model.Services.MetaService
{

    public interface IMetaService 
    {
        public Task AddMeta(Meta meta);
        public Task<Meta?> GetMetaById(int id);
        public Task SaveChangesAsync();
        public Task<List<Meta>> GetAllMeta();
    }

    public class MetaService : IMetaService
    {
        private readonly IMetaRepository _metaRepository;

        public MetaService(IMetaRepository repository)
        {
            _metaRepository = repository;
        }

        public Task AddMeta(Meta meta)
        {
            return _metaRepository.AddMeta(meta);
        }

        public async Task<Meta?> GetMetaById(int id)
        {
            return await _metaRepository.GetMetaById(id);
        }
        public async Task<List<Meta>> GetAllMeta()
        {
            return await _metaRepository.GetAllMeta();
        }

        public async Task SaveChangesAsync()
        {
            await _metaRepository.SaveChangesAsync();
        }

    }
}
