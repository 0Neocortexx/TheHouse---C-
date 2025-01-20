using Model.Entities.Visitas;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.Visitas
{
    public class VisitaService : IVisitaService
    {
        public readonly IVisitaRepository _repository;

        public VisitaService(IVisitaRepository visitasRepository)
        {
            _repository = visitasRepository ;
        }
        public async Task<List<Visita>> GetAllVisita()
        {
            return (await _repository.GetAllVisita()).ToList();
        }

        public async Task<Visita?> GetVisitaById(int id)
        {
            return await _repository.GetVisitaById(id);
        }

        public async Task AddVisita(Visita visita)
        {
            await _repository.AddVisita(visita);
        }
        public async Task SaveChangesAsync()
        {
            await _repository.SaveChangesAsync();
        }
    }
}
