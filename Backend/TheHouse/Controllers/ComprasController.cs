using AutoMapper;
using Dtos.VisitaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.Compras;
using Model.Entities.Compras;
using Model.Services.CompraService;
using Model.Services.Interfaces;

namespace TheHouse.Controllers
{
    [Route("api/compras")]
    [ApiController]
    public class ComprasController : Controller
    {

        private readonly ICompraService _service;
        private readonly IMapper _mapper;

        public ComprasController(ICompraService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<ComprasDto>>> GetCompras()
        {
            try
            {
                var compras = await _service.GetAllCompras();

                if(compras == null)
                {
                    ActionResult actionNull = Ok("Nenhuma compra encontrada!");
                    return actionNull;
                }

                return Ok(_mapper.Map<List<ListaDeCompra>>(compras));
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ComprasDto>> GetCompra(int id)
        {
            var compra = await _service.GetCompraById(id);
            if (compra == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ComprasDto>(compra));
        }

        [HttpPost]
        public async Task<ActionResult<ComprasDto>> CreateCompra(CreateComprasDto response)
        {
            try
            {
                var compra = _mapper.Map<ListaDeCompra>(response);

                await _service.AddCompra(compra);

                await _service.SaveChangesAsync();

                var ComprasDto = _mapper.Map<ComprasDto>(compra);

                return CreatedAtAction(nameof(GetCompra), new { id = ComprasDto.Id }, ComprasDto);
            }
            catch(Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }

    }
}
