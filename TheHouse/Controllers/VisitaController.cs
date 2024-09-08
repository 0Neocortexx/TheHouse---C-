using AutoMapper;
using Dtos.VisitaDto;
using Microsoft.AspNetCore.Mvc;
using Model.Entities.Visita;
using Model.Repositories.Entretenimento;

namespace VisitasApi.Controllers
{
    [Route("api/visita")]
    [ApiController]
    public class VisitaController : Controller {

        private readonly IVisitaRepository _repository;
        private readonly IMapper _mapper;

        public VisitaController(IVisitaRepository repository,IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitaDto>>> GetVisitas() {
            var visitas = await _repository.GetAllVisita();
            return Ok(_mapper.Map<IEnumerable<VisitaDto>>(visitas));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VisitaDto>> GetVisita(int id) {
            var visita = await _repository.GetVisitaById(id);
            if(visita == null) {
                return NotFound();
            }
            return Ok(_mapper.Map<VisitaDto>(visita));
        }

        [HttpPost]
        public async Task<ActionResult<VisitaDto>> CreateVisita(CreateVisitaDto visitasDto) {
            
            var visita = _mapper.Map<Visita>(visitasDto);

            await _repository.AddVisita(visita);

            await _repository.SaveChangesAsync();

            var visitaDto = _mapper.Map<VisitaDto>(visita);

            return CreatedAtAction(nameof(GetVisita),new { id = visitaDto.Id },visitaDto);
        }

    }
}
