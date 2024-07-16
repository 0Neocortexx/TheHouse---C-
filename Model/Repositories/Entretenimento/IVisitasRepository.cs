using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Entretenimento;

namespace Model.Repositories.Entretenimento {

    public interface IVisitasRepository {
        Task<IEnumerable<Visitas>> GetAllVisitas();
        Task<Visitas?> GetVisitaById(int id);
        Task AddVisita(Visitas visita);
        Task SaveChangesAsync();
    }

    public class VisitasRepository :IVisitasRepository {
        private readonly TheHouseContext _context;

        public VisitasRepository(TheHouseContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Visitas>> GetAllVisitas() {
            return await _context.Visitas.ToListAsync();
        }

        public async Task<Visitas?> GetVisitaById(int id) {
            return await _context.Visitas.FindAsync(id);
        }

        public async Task AddVisita(Visitas visita) {
            await _context.Visitas.AddAsync(visita);
        }

        public async Task SaveChangesAsync() {
            await _context.SaveChangesAsync();
        }
    }
}
