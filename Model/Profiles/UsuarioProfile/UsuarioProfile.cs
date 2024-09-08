using AutoMapper;
using Model.DTOs.UsuarioDto;
using Model.Entities.Usuario;

namespace Model.Profiles.UsuarioProfile
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() {
            // Mapear de Usuario para UsuarioDto
            CreateMap<Usuario, UsuarioDto>();
            // Mapear de UsuarioDto para Usuario
            CreateMap<UsuarioDto, Usuario>();
        }
    }
}
