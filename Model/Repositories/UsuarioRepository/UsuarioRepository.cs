using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.Usuario;

namespace Model.Repositories.UsuarioRepository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllUsuario();
        Task<Usuario?> GetUsuarioById(int id);
        Task AddUsuario(Usuario usuario);
        Task SaveChangesAsync();
    }

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly TheHouseContext _context;

        public UsuarioRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuario()
        {
           return await _context.usuario.ToListAsync();
        }

        public async Task<Usuario?> GetUsuarioById(int id) { 
            return await _context.usuario.FindAsync(id);
        }

        public async Task AddUsuario(Usuario usuario)
        {
            await _context.usuario.AddAsync(usuario);   
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
