using AutoMapper;
using Dtos.Visitas;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.Compras;
using Model.Entities.Compras;
using Model.Repositories.Compras;

namespace TheHouse.Controllers
{
    [Route("api/compras")]
    [ApiController]
    public class ComprasController : ControllerBase
    {

        private readonly IComprasRepository _repository;
        private readonly IMapper _mapper;

        public ComprasController(IComprasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComprasDto>>> GetCompras()
        {
            var compras = await _repository.GetAllCompras();
            return Ok(_mapper.Map<IEnumerable<VisitasDto>>(compras));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ComprasDto>> GetCompra(int id)
        {
            var compra = await _repository.GetComprasById(id);
            if (compra == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ComprasDto>(compra));
        }

        [HttpPost]
        public async Task<ActionResult<ComprasDto>> CreateCompra(ComprasDto response)
        {
            var compra = _mapper.Map<ListaDeCompras>(response);

            await _repository.AddCompra(compra);
            await _repository.SaveChangesAsync();


            var ComprasDto = _mapper.Map<ComprasDto>(compra);
            return CreatedAtAction(nameof(GetCompra), new { id = ComprasDto.Id }, ComprasDto);
        }

    }
}
