using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.MetaDto;
using Model.Entities.GrupoMeta;
using Model.Repositories.MetaRepository;

namespace TheHouse.Controllers
{
    [Route("api/meta")]
    [ApiController]
    public class MetaController : Controller
    {
        private readonly IMetaRepository _repository;
        private readonly IMapper _mapper;

        public MetaController(IMetaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meta>>> GetMetas() 
        {
            var metas = await _repository.GetAllMeta();
            return Ok(_mapper.Map<MetaDto>(metas));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Meta>> GetMetaById(int id)
        {
            var meta = await _repository.GetMetaById(id);
            if (meta == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MetaDto>(meta));
        }

        [HttpPost]
        public async Task<ActionResult<MetaDto>> AddMeta(CreateMetaDto createMetaDto)
        {
            try
            {
                var meta = _mapper.Map<Meta>(createMetaDto);
                Console.WriteLine("Mapeou a entidade");
                await _repository.AddMeta(meta);
                Console.WriteLine("Adicionou a entidade");
                await _repository.SaveChangesAsync();
                var response = _mapper.Map<MetaDto>(meta);
                return CreatedAtAction(nameof(GetMetaById), new { id = response.Id }, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Erro interno do servidor! \n" + "Erro: " + e);
            }
        }
    }
}
