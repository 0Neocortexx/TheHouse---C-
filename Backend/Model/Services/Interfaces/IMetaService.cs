using Model.Entities.Metas;

namespace Model.Services.Interfaces
{
    public interface IMetaService
    {
        public Task AddMeta(Meta meta);
        public Task<Meta?> GetMetaById(int id);
        public Task SaveChangesAsync();
        public Task<List<Meta>> GetAllMeta();
    }
}
