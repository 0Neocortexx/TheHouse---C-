using Model.Enums.Visita;

namespace Dtos.VisitaDto
{
    public class VisitaDto {
        public int Id { get; set; }
        public string Local { get; set; }
        public string? DataVisita { get; set; }
        public StatusVisita statusVisita { get; set; }
    }

    public class CreateVisitaDto {
        public string Local { get; set; }
        public string? DataVisita { get; set; }
        public StatusVisita statusVisita { get; set; }
    }
}