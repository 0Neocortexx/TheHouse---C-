using Model.Entities.Visita;

namespace Model.Repositories.Entretenimento
{
    public interface VisitaService {
        Task<IEnumerable<Visita>> GetAllVisita();
        Task<Visita?> GetVisitaById(int id);
        Task AddVisita(Visita visita);
        Task SaveChangesAsync();
    }   
}
