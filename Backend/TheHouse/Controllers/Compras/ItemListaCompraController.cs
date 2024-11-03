using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.DtosCompra.ItemLista;
using Model.Services.Interfaces;

namespace TheHouse.Controllers.Compras
{
    [ApiController]
    [Route("api")]
    public class ItemListaCompraController : Controller
    {
        private readonly IItemListaCompraService _service;
        private readonly IMapper _mapper;

        public ItemListaCompraController(IItemListaCompraService itemListaCompraService, IMapper mapper)
        {
            _service = itemListaCompraService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("itemcompra")]
        public async Task<ActionResult<List<GetItemListaCompraDto>>> GetCompras()
        {
            try
            {
                var compras = await _service.GetAllItemCompra();

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
        [HttpGet("itemcompra/{id}")]
        public async Task<ActionResult<GetItemListaCompraDto>> GetCompra(int id)
        {
            try
            {
                var compra = await _service.GetItemCompraById(id);

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
        [HttpPost("itemcompra/novo")]
        public async Task<ActionResult> CreateCompra([FromBody] CreateItemListaCompraDto data)
        {
            try
            {
                await _service.AddItemListaCompra(data);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }
    }
}
