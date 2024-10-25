using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Visita;
using Model.Repositories.Entretenimento;

namespace Model.Services.VisitaService
{
    public class VisitaService : Repositories.Entretenimento.VisitaService
    {
        private readonly TheHouseContext _context;

        public VisitaService(TheHouseContext context)
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
            await _context.Visita.AddAsync(visita);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
