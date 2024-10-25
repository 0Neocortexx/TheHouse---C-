using Model.Entities.GrupoUsuario;

namespace Model.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetUsuarioById(int id);
        Task AddUsuario(Usuario usuario);
        Task SaveChangesAsync();
    }
}
