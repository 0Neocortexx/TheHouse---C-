using AutoMapper;
using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;

namespace Model.Profiles.UsuarioProfile
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() {

            CreateMap<Usuario, UsuarioDto>().ReverseMap();

            CreateMap<UsuarioLoginDto, Usuario>().ReverseMap();

            CreateMap<UsuarioCadastroDto, Usuario>().ReverseMap();
        }
    }
}
