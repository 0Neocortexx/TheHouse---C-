using Model.Enums.Entretenimento;

namespace Dtos.Visitas {
    public class VisitasDto {
        public int Id { get; set; }
        public string Local { get; set; }
        public string? DataVisita { get; set; }
        public StatusVisita statusVisita { get; set; }
    }

    public class CreateVisitasDto {
        public string Local { get; set; }
        public string? DataVisita { get; set; }
        public StatusVisita statusVisita { get; set; }
    }
}