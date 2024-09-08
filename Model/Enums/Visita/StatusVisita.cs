using System.ComponentModel;

namespace Model.Enums.Visita
{
    public enum StatusVisita
    {
        [Description ("Locais ainda não visitados")]
        NaoVisitado = 0,
        [Description ("Locais já visitados")]
        Visitado = 1
    }
}
