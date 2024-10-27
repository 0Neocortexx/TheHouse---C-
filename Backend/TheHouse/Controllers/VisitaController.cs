using AutoMapper;
using Dtos.VisitaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Entities.Visita;
using Model.Services.Interfaces;

namespace VisitasApi.Controllers
{
    [Route("api/visita")]
    [ApiController]
    public class VisitaController : Controller {

        public  readonly IVisitaService _service;
        public readonly IMapper _mapper;

        public VisitaController(IVisitaService service,IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<VisitaDto>>> GetVisitas() 
        {
            try
            {
                var visitas = await _service.GetAllVisita();

                if (visitas == null)
                {
                    ActionResult actionResultNull = Ok("Não existem visitas cadastradas");
                    return actionResultNull;
                }
                ActionResult actionResult = Ok(_mapper.Map<List<VisitaDto>>(visitas));

                return actionResult;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<VisitaDto>> GetVisita(int id) {
            try
            {
                var visita = await _service.GetVisitaById(id);

                if (visita == null)
                {
                    return NotFound();
                }
                return Ok(_mapper.Map<VisitaDto>(visita));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<VisitaDto>> CreateVisita(CreateVisitaDto createVisitasDto) 
        {
            try
            {
                var visita = _mapper.Map<Visita>(createVisitasDto);

                await _service.AddVisita(visita);

                await _service.SaveChangesAsync();

                var visitaDto = _mapper.Map<VisitaDto>(visita);

                return CreatedAtAction(nameof(GetVisita), new { id = visitaDto.Id }, visitaDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
