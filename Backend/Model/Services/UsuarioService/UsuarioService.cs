using AutoMapper;
using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;
using Model.Repositories.Interfaces;
using Model.Services.Interfaces;

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
            Usuario? usuarioLogin = _repository.GetUsuarioByEmail(email);

            return _mapper.Map<UsuarioLoginDto>(usuarioLogin);
            
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
