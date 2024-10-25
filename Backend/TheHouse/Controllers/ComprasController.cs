using AutoMapper;
using Dtos.VisitaDto;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.Compras;
using Model.Entities.Compras;
using Model.Services.CompraService;

namespace TheHouse.Controllers
{
    [Route("api/compras")]
    [ApiController]
    public class ComprasController : Controller
    {

        private readonly CompraService _service;
        private readonly IMapper _mapper;

        public ComprasController(CompraService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComprasDto>>> GetCompras()
        {
            var compras = await _service.GetAllCompras();
            return Ok(_mapper.Map<IEnumerable<VisitaDto>>(compras));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ComprasDto>> GetCompra(int id)
        {
            var compra = await _service.GetComprasById(id);
            if (compra == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ComprasDto>(compra));
        }

        [HttpPost]
        public async Task<string> CreateCompra(CreateComprasDto response)
        {
            Console.WriteLine("Entrou na request"); 
            var compra = _mapper.Map<ListaDeCompras>(response);
            await _service.AddCompra(compra);
            await _service.SaveChangesAsync();


            var ComprasDto = _mapper.Map<ComprasDto>(compra);
            Console.WriteLine(ComprasDto);
            // return CreatedAtAction(nameof(GetCompra), new { id = ComprasDto.Id }, ComprasDto);
            return "OK";
        }

    }
}
