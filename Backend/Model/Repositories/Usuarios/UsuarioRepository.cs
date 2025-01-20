using Model.Context;
using Model.Entities.Usuarios;
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

        public async Task<Usuario?> GetUsuarioById(Guid id)
        {
            return await _context.Usuario.FindAsync(id);
        }

        public Usuario? GetUsuarioByEmail(string email)
        {
            return _context.Usuario.ToList().Where(u => u.Email.Equals(email)).FirstOrDefault();
            // O Where Fará um select na tabela Usuario procurando um email que seja igual ao email procurado
            // Se utilizar somente o First, caso não seja encontrado nada, ocorrerá erro
            // FirstOrDefault pegará o primeiro item da lista ou retornará nulo
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
