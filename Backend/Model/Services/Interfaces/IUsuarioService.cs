using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;

namespace Model.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Usuario?> GetUsuarioById(int id);
        public Task AddUsuario(UsuarioCadastroDto usuario);
        public UsuarioLoginDto? GetUsuarioByEmail(string email);
        public bool TemCampoVazioLogin(UsuarioLoginDto usuario);
        public bool TemCampoVazioCadastro(UsuarioCadastroDto usuario);
        public bool IsLoginVerificado(UsuarioLoginDto usuario);
        public string GerarTokenUsuario(string email);
        public bool IsEmailJaCadastrado(string email);

    }
}
