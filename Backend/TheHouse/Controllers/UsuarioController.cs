using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;
using Model.Repositories.UsuarioRepository;

namespace TheHouse.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _service;
        private readonly IMapper _mapper;

        public UsuarioController (UsuarioService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAllUsuario()
        {
            var usuarios = await _service.GetAllUsuario();
            return Ok(_mapper.Map<IEnumerable<UsuarioDto>>(usuarios));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDto>> GetUsuarioById(int id)
        {
            var usuario = await _service.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<UsuarioDto>(usuario));
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioDto>> AddUsuario(CreateUsuarioDto usuarioDto) {

            try
            {
                var usuario = _mapper.Map<Usuario>(usuarioDto);
                await _service.AddUsuario(usuario);
                await _service.SaveChangesAsync();
                return CreatedAtAction(nameof(GetUsuarioById), new { id = usuario.Id }, usuario);

            } catch (AutoMapperMappingException e)  
            { 
                return BadRequest("Erro no Mapeamento de entidades!\n " + " \nErro: " + e);
            } catch (Exception)
            {
                return StatusCode(500, "Erro interno do servidor");
            }
         
        }

    }
}
