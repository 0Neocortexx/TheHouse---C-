using Model.Entities.GrupoUsuario;

namespace Model.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Usuario?> GetUsuarioById(int id);
        public Task AddUsuario(Usuario usuario);
        public Task SaveChangesAsync();
    }
}
