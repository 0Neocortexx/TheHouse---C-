using Model.Entities.GrupoUsuario;

namespace Model.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetUsuarioById(Guid id);
        Usuario? GetUsuarioByEmail(string email);
        Task AddUsuario(Usuario usuario);
        Task SaveChangesAsync();
    }
}
