using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Visitas;
using Model.Repositories.Interfaces;

namespace Model.Repositories.Entretenimento
{
    public class VisitasRepository : IVisitaRepository
    {
        public readonly TheHouseContext _context;

        public VisitasRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Visita>> GetAllVisita()
        {
            return await _context.Visita.ToListAsync();
        }

        public async Task<Visita?> GetVisitaById(int id)
        {
            return await _context.Visita.FindAsync(id);
        }

        public async Task AddVisita(Visita visita)
        {
            await _context.AddAsync(visita);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }   
}
