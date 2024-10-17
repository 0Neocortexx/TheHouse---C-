using Model.Context;
using Model.Repositories.MetaRepository;
using Model.Entities.GrupoMeta;
using Microsoft.EntityFrameworkCore;

namespace Model.Services.MetaService
{
    public class MetaService : IMetaRepository
    {
        private readonly TheHouseContext _context;

        public MetaService(TheHouseContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Meta>> GetAllMeta()
        {
            return await _context.Meta.ToListAsync();
        }
        public async Task<Meta?> GetMetaById(int id)
        {
            return await _context.Meta.FindAsync(id);
        }
        public async Task AddMeta(Meta meta)
        {
            await _context.Meta.AddAsync(meta);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
