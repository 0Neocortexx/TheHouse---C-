using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Metas;
using Model.Repositories.Interfaces;

namespace Model.Repositories.Metas
{
    public class MetaRepository : IMetaRepository
    {
        public readonly TheHouseContext _context;

        public MetaRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task AddMeta(Meta meta)
        {
            await _context.AddAsync(meta);
        }

        public async Task<Meta?> GetMetaById(int id)
        {
            return await _context.Meta.FindAsync(id);
        }

        public async Task<IEnumerable<Meta>> GetAllMeta()
        {
            return await _context.Meta.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
