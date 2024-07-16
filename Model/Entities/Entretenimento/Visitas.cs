using Model.Enums.Entretenimento;

namespace Model.Entities.Entretenimento {
    public class Visitas
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataVisita { get; set; }
        public StatusVisita StatusVisita { get; set; }

        public Visitas() { }

        public Visitas(int id, string local, DateTime? dataVisita, StatusVisita statusVisita)
        {
            this.Id = id;
            this.Local = local;
            this.DataVisita = dataVisita;
            this.StatusVisita = statusVisita;
        }
    }
}
