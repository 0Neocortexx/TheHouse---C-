using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.GrupoMeta;

namespace Model.Repositories.MetaRepository
{
    public interface IMetaRepository
    {
        Task<List<Meta>> GetAllMeta();
        Task<Meta?> GetMetaById(int id);
        Task SaveChangesAsync();
        Task AddMeta(Meta meta);
    }

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

        public async Task<List<Meta>> GetAllMeta()
        {
            return await _context.Meta.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
