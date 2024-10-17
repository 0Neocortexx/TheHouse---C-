using Model.Entities.GrupoMeta;

namespace Model.Repositories.MetaRepository
{
    public interface IMetaRepository
    {
        Task<IEnumerable<Meta>> GetAllMeta();
        Task<Meta?> GetMetaById(int id);
        Task AddMeta(Meta meta);
        Task SaveChangesAsync();
    }
}
