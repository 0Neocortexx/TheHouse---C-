using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.DtosCompra.ListaCompra;
using Model.Services.Interfaces;

namespace TheHouse.Controllers.Compras
{
    [Route("api/listacompra")]
    [ApiController]
    public class ListaCompraController : Controller
    {
        private readonly IListaCompraService _listaCompraService;
        private readonly IMapper _mapper;

        public ListaCompraController(IListaCompraService listaCompraService, IMapper mapper)
        {
            _listaCompraService = listaCompraService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<GetListaCompraDto>>> GetListasDeCompra()
        {
            try
            {
                var compras = await _listaCompraService.GetAllListaCompra();

                if (compras == null)
                    return StatusCode(200, null);

                return Ok(compras);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<GetListaCompraDto>> GetListaDeCompra(int id)
        {
            try
            {
                var compra = await _listaCompraService.GetListaCompraById(id);

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
        public async Task<ActionResult> CreateListaCompra([FromBody] CreateListaCompraDto data)
        {
            try
            {
                await _listaCompraService.AddListaCompra(data);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }
    }
}
