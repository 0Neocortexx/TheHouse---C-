using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entities.GrupoUsuario;

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
           return await _context.Usuario.ToListAsync();
        }

        public async Task<Usuario?> GetUsuarioById(int id) { 
            return await _context.Usuario.FindAsync(id);
        }

        public async Task AddUsuario(Usuario usuario)
        {
            await _context.Usuario.AddAsync(usuario);   
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
