using Model.Context;
using Model.Entities.GrupoUsuario;
using Model.Repositories.Interfaces;

namespace Model.Repositories.UsuarioRepository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly TheHouseContext _context;

        public UsuarioRepository(TheHouseContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> GetUsuarioById(int id)
        {
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
