using Model.Enums.Visitas;

namespace Model.Entities.Visitas
{
    public class Visita
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataVisita { get; set; }
        public EStatusVisita StatusVisita { get; set; }

        public Visita() { }

        public Visita(int id, string local, DateTime? dataVisita, EStatusVisita statusVisita)
        {
            this.Id = id;
            this.Local = local;
            this.DataVisita = dataVisita;
            this.StatusVisita = statusVisita;
        }
    }
}
