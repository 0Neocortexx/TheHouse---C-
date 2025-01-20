using AutoMapper;
using Model.DTOs.Usuarios;
using Model.Entities.Usuarios;

namespace Model.Profiles.Usuarios
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() {

            CreateMap<UsuarioDto, Usuario>().ReverseMap();

            CreateMap<UsuarioLoginDto, Usuario>().ReverseMap();

            CreateMap<UsuarioCadastroDto, Usuario>().ReverseMap();

            CreateMap<UsuarioLoginDto, ResponseUsuarioLoginDto>();
        }
    }
}
