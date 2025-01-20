using Model.DTOs.Usuarios;

namespace Model.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<UsuarioDto?> GetUsuarioById(Guid id);
        public Task AddUsuario(UsuarioCadastroDto usuario);
        public UsuarioDto? GetUsuarioByEmail(string email);
        public bool TemCampoVazioLogin(UsuarioLoginDto usuario);
        public bool TemCampoVazioCadastro(UsuarioCadastroDto usuario);
        public bool IsLoginVerificado(UsuarioLoginDto usuario);
        public string GerarTokenUsuario(string email);
        public bool IsEmailJaCadastrado(string email);

    }
}
