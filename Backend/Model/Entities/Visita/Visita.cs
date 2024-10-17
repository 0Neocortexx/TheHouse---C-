using Model.Enums.Visita;

namespace Model.Entities.Visita
{
    public class Visita
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataVisita { get; set; }
        public StatusVisita StatusVisita { get; set; }

        public Visita() { }

        public Visita(int id, string local, DateTime? dataVisita, StatusVisita statusVisita)
        {
            this.Id = id;
            this.Local = local;
            this.DataVisita = dataVisita;
            this.StatusVisita = statusVisita;
        }
    }
}
