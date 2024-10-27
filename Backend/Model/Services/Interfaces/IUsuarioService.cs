using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;

namespace Model.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Usuario?> GetUsuarioById(int id);
        public Task AddUsuario(Usuario usuario);
        public UsuarioLoginDto? GetUsuarioByEmail(string email);
        public Task SaveChangesAsync();
    }
}
