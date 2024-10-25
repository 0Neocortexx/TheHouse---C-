using Model.Entities.GrupoUsuario;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

namespace Model.Services.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _repository = usuarioRepository;
        }

        public async Task<Usuario?> GetUsuarioById(int id)
        {
            return await _repository.GetUsuarioById(id);
        }

        public async Task AddUsuario(Usuario usuario)
        {
            await _repository.AddUsuario(usuario);
        }

        public async Task SaveChangesAsync()
        {
            await _repository.SaveChangesAsync();
        }
    }
}
