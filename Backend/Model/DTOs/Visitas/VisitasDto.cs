using Model.Enums.Visitas;

namespace DTOs.Visitas
{
    public class VisitaDto {
        public int Id { get; set; }
        public string? Local { get; set; }
        public string? DataVisita { get; set; }
        public EStatusVisita statusVisita { get; set; }
    }

    public class CreateVisitaDto {
        public string? Local { get; set; }
        public string? DataVisita { get; set; }
        public EStatusVisita statusVisita { get; set; }
    }
}