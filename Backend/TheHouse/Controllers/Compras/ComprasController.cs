using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.DtosCompra.Compras;
using Model.DTOs.UsuarioDto;
using Model.Services.Interfaces;
using Util.ManipulationStrings;

namespace TheHouse.Controllers.Compras
{
    [Route("api/compra")]
    [ApiController]
    public class ComprasController : Controller
    {

        private readonly ICompraService _compraService;
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public ComprasController(ICompraService compraService, IMapper mapper, IUsuarioService usuarioService)
        {
            _compraService = compraService;
            _mapper = mapper;
            _usuarioService = usuarioService;
        }

        [Authorize]
        [HttpGet("{userId}")]
        public async Task<ActionResult<List<GetCompraDto>>> GetComprasByUser(Guid userId)
        {
            try
            {
                var userCompras = await _compraService.GetAllComprasByUserId(userId);

                if (userCompras == null)
                    return StatusCode(200, null);

                return Ok(userCompras);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [Authorize]
        [HttpGet("{Userid}/{id}")]
        public async Task<ActionResult<GetCompraDto>> GetCompra(int id)
        {
            try
            {
                var compra = await _compraService.GetCompraById(id);

                if (compra == null)
                    return NotFound();

                return Ok(compra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [HttpPost("novo")]
        public async Task<ActionResult> CreateCompra([FromBody] CreateCompraDto data)
        {
            try
            {
                await _compraService.AddCompra(data);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }
    }
}
