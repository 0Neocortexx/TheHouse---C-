﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.Usuarios;
using Model.Services.Interfaces;
using Util.ManipulationStrings;

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
                // Verificar se a senha ou o email estão vazios (Irá para outra DLL)
                if (_service.TemCampoVazioLogin(usuarioLoginDto) == true)
                    return StatusCode(500, "Algum campo está vazio");

                // Formata o email removendo os espaços e colocando em lowercase
                usuarioLoginDto.Email = LoginStrings.FormatarEmail(usuarioLoginDto.Email);

                // Realiza a verificação do login
                if(_service.IsLoginVerificado(usuarioLoginDto) == false)
                    return Unauthorized();

                UsuarioDto? userData = _service.GetUsuarioByEmail(usuarioLoginDto.Email);

                // Gera um novo token para o usuario
                string token = _service.GerarTokenUsuario(usuarioLoginDto.Email);

                // Retorna a response com o email e o token de usuário
                ResponseUsuarioLoginDto response = new ResponseUsuarioLoginDto() { Id = userData.Id, Nome = userData.Nome, Email = userData.Email, Token = token };

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
                // Verificar se a senha ou o email estão vazios
                if (_service.TemCampoVazioCadastro(usuarioCadastro) == true)
                    return StatusCode(500, "Preencha todos os campos!");

                // Formata o email recebido
                usuarioCadastro.Email = LoginStrings.FormatarEmail(usuarioCadastro.Email);

                // Verifica se o email já existe na base de dados
                if (_service.IsEmailJaCadastrado(usuarioCadastro.Email) == true)
                    return StatusCode(500, "Email já cadastrado!");

                // Adiciona no banco
                await _service.AddUsuario(usuarioCadastro);

                // Gera um novo token para o usuario
                string token = _service.GerarTokenUsuario(usuarioCadastro.Email);

                // Monta uma nova entidade de resposta
                ResponseUsuarioLoginDto novoUsuario = new ResponseUsuarioLoginDto() { Email = usuarioCadastro.Email, Token = token};

                return Ok(novoUsuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        } 
    }
}