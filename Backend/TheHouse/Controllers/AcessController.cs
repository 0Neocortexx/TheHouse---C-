using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.UsuarioDto;
using Model.Entities.GrupoUsuario;
using Model.Security;
using Model.Services.Interfaces;

namespace TheHouse.Controllers
{
    [ApiController]
    [Route("api")]
    public class AcessController : Controller
    {
        public readonly IUsuarioService _service;
        public readonly IMapper _mapper;

        public AcessController(IUsuarioService UsuarioService, IMapper mapper)
        {
            _service = UsuarioService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioLoginDto usuarioLoginDto)
        {
            try
            {
                UsuarioLoginDto? usuarioLoginBanco = _service.GetUsuarioByEmail(usuarioLoginDto.Email);

                if (usuarioLoginBanco == null || !usuarioLoginBanco.Senha.Equals(usuarioLoginDto.Senha))
                {
                    return Unauthorized();
                }

                TheHouseToken theHouseToken = new TheHouseToken();

                string token = theHouseToken.GerarToken(usuarioLoginBanco.Email);

                ResponseUsuarioLogin response = new ResponseUsuarioLogin() { Email = usuarioLoginBanco.Email, Token = token };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> Cadastro([FromBody] UsuarioCadastroDto usuarioCadastro)  
        {
            try
            {
                UsuarioLoginDto? usuarioBanco = _service.GetUsuarioByEmail(usuarioCadastro.Email);

                usuarioCadastro.Email.ToLower();

                if (usuarioBanco != null)
                {
                    return StatusCode(500, "Esse email já existe no sistema!");
                }

                Usuario newUsuario = _mapper.Map<Usuario>(usuarioCadastro);

                await _service.AddUsuario(newUsuario);

                await _service.SaveChangesAsync();

                TheHouseToken theHouseToken = new TheHouseToken();

                string token = theHouseToken.GerarToken(usuarioCadastro.Email);

                ResponseUsuarioLogin novoUsuario = new ResponseUsuarioLogin() { Email = usuarioCadastro.Email, Token = token};

                return Ok(novoUsuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        } 
    }
}