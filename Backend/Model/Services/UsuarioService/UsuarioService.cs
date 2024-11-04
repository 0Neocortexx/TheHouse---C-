using AutoMapper;
using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;
using Security.AcessToken;
using Security.Criptopass;
using Util.ManipulationStrings;

namespace Model.Services.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _repository;
        public readonly IMapper _mapper;
        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper) 
        {
            _repository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<Usuario?> GetUsuarioById(int id)
        {
            return await _repository.GetUsuarioById(id);
        }

        public UsuarioLoginDto? GetUsuarioByEmail(string email)
        {
            try
            {
                Usuario? usuarioLogin = _repository.GetUsuarioByEmail(email);

                if (usuarioLogin == null)
                {
                   return null;
                }

                return _mapper.Map<UsuarioLoginDto>(usuarioLogin);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool TemCampoVazioLogin(UsuarioLoginDto usuario)
        {
            if (usuario.Email == null || usuario.Senha == null)
            {
                return true;
            }
            return false;
        }

        public bool TemCampoVazioCadastro(UsuarioCadastroDto usuario)
        {
            if (usuario.Email == "" || usuario.Senha == "" || usuario.Nome == "")
            {
                return true;
            }
            return false;
        }

        public bool IsLoginVerificado(UsuarioLoginDto usuario)
        {
            // Converte a senha informada em HASH
            usuario.Senha = Criptografia.GerarHashSHA256(usuario.Senha);

            // Verificar se existe usuario com o email informado
            UsuarioLoginDto? usuarioLoginBanco = GetUsuarioByEmail(usuario.Email);
 
            // Verifica se o usuario procurado foi nulo ou se a senha informada é diferente da senha do banco
            if (usuarioLoginBanco == null || !usuario.Senha.Equals(usuarioLoginBanco.Senha))
                return false;

            // Caso passar pela verificação retorna true
            return true;
        }

        public bool IsEmailJaCadastrado(string email)
        {
            UsuarioLoginDto? usuarioBanco = GetUsuarioByEmail(email);

            if (usuarioBanco != null)
                return true;

            return false;
        }

        public string GerarTokenUsuario(string email)
        {
            TheHouseToken theHouseToken = new TheHouseToken();
            
            string token = theHouseToken.GerarToken(email);

            return token; // Passar o novo token ao usuário
        }

        public async Task AddUsuario(UsuarioCadastroDto usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHashSHA256(usuario.Senha);

                Usuario newUsuario = _mapper.Map<Usuario>(usuario);

                await _repository.AddUsuario(newUsuario);

                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
