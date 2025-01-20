using Model.Entities.Visitas;

namespace Model.Repositories.Interfaces
{
    public interface IVisitaRepository
    {
        Task<IEnumerable<Visita>> GetAllVisita();
        Task<Visita?> GetVisitaById(int id);
        Task AddVisita(Visita visita);
        Task SaveChangesAsync();
    }
}
