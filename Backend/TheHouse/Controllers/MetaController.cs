using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs.MetaDto;
using Model.Entities.GrupoMeta;
using Model.Services.Interfaces;

namespace TheHouse.Controllers
{
    [Route("api/meta")]
    [ApiController]
    public class MetaController : Controller
    {
        private readonly IMetaService _service;
        private readonly IMapper _mapper;

        public MetaController(IMetaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<MetaDto>>> GetMetas() 
        {
            try
            {
                List<Meta> metas = await _service.GetAllMeta();

                if (metas == null)
                {
                    ActionResult actionNull = Ok("Nenhuma meta encontrada!");
                    return actionNull;
                }

                ActionResult action = Ok(_mapper.Map<List<MetaDto>>(metas));

                return action;
            } 
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Meta>> GetMetaById(int id)
        {
            try
            {
                var meta = await _service.GetMetaById(id);

                if (meta == null)
                {
                    return NotFound();
                }
                return Ok(_mapper.Map<MetaDto>(meta));

            } catch(Exception ex)
            {
                return StatusCode(500, ex.Message.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<MetaDto>> AddMeta(CreateMetaDto createMetaDto)
        {
            try
            {
                var meta = _mapper.Map<Meta>(createMetaDto);

                await _service.AddMeta(meta);

                await _service.SaveChangesAsync();

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
