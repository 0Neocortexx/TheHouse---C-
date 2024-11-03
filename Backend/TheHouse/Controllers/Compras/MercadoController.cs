using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.CompraDto.Mercado;
using Model.Services.Interfaces;
using Npgsql.Replication.PgOutput.Messages;

namespace TheHouse.Controllers.Compras
{
    [ApiController]
    [Route("api")]
    public class MercadoController : Controller
    {
        private readonly IMercadoService _mercadoService;
        private readonly IMapper _mapper;
        public MercadoController(IMercadoService mercadoService, IMapper mapper)
        {
            _mercadoService = mercadoService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("mercado")]
        public async Task<ActionResult<List<GetMercadoDto>>> GetMercados()
        {
            try
            {
                var mercados = await _mercadoService.GetAllMercado();

                if (mercados == null)
                    return StatusCode(200, null);

                return Ok(mercados);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [Authorize]
        [HttpGet("mercado/{id}")]
        public async Task<ActionResult<GetMercadoDto>> GetMercado(int id)
        {
            try
            {
                var mercado = await _mercadoService.GetMercadoById(id);

                if (mercado == null)
                    return NotFound();

                return Ok(mercado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [HttpPost("mercado/novo")]
        public async Task<ActionResult> CreateCompra([FromBody] CreateMercadoDto data)
        {
            try
            {
                await _mercadoService.AddMercado(data);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }
    }
}
