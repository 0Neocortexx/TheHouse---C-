using AutoMapper;
using Dtos.Visitas;
using Microsoft.AspNetCore.Mvc;
using Model.Entities.Entretenimento;
using Model.Repositories.Entretenimento;

namespace VisitasApi.Controllers {
    [Route("api/visitas")]
    [ApiController]
    public class VisitasController :ControllerBase {

        private readonly IVisitasRepository _repository;
        private readonly IMapper _mapper;

        public VisitasController(IVisitasRepository repository,IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitasDto>>> GetVisitas() {
            var visitas = await _repository.GetAllVisitas();
            return Ok(_mapper.Map<IEnumerable<VisitasDto>>(visitas));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VisitasDto>> GetVisita(int id) {
            var visita = await _repository.GetVisitaById(id);
            if(visita == null) {
                return NotFound();
            }
            return Ok(_mapper.Map<VisitasDto>(visita));
        }

        [HttpPost]
        public async Task<ActionResult<VisitasDto>> CreateVisita(VisitasDto visitasDto) {
            var visita = _mapper.Map<Visitas>(visitasDto);
            Console.WriteLine("Passou do mapper");

            await _repository.AddVisita(visita);
            await _repository.SaveChangesAsync();

        
            var visitaDto = _mapper.Map<VisitasDto>(visita);
            return CreatedAtAction(nameof(GetVisita),new { id = visitaDto.Id },visitaDto);
        }

    }
}
