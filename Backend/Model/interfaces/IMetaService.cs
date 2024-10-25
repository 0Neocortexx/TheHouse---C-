using Model.Entities.GrupoMeta;

namespace Model.interfaces
{
    public interface IMetaService
    {
        Task<List<Meta>> GetAllMeta();
    }
}
