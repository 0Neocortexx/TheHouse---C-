using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.GrupoMeta;

namespace Model.Repositories.MetaRepository
{
    public interface IMetaRepository
    {
        Task<IEnumerable<Meta>> GetAllMeta();
        Task<Meta?> GetMetaById(int id);
        Task AddMeta(Meta meta);
        Task SaveChangesAsync();
    }

    public class MetaRepository : IMetaRepository
    {
        private readonly TheHouseContext _context;

        public MetaRepository(TheHouseContext context)
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
