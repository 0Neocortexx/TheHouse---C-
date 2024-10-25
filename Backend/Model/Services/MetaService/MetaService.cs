using Model.Entities.GrupoMeta;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;


namespace Model.Services.MetaService
{

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
            return (await _metaRepository.GetAllMeta()).ToList();
        }

        public async Task SaveChangesAsync()
        {
            await _metaRepository.SaveChangesAsync();
        }

    }
}
