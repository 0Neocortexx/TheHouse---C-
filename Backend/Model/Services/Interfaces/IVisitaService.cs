using Model.Entities.Visitas;

namespace Model.Services.Interfaces
{
    public interface IVisitaService
    {
        public Task<List<Visita>> GetAllVisita();
        public Task<Visita?> GetVisitaById(int id);
        public Task AddVisita(Visita visita);
        public Task SaveChangesAsync();
    }
}
