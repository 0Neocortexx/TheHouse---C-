using System.ComponentModel;

namespace Model.Enums.Visitas
{
    public enum EStatusVisita
    {
        [Description ("Locais ainda não visitados")]
        NaoVisitado = 0,
        [Description ("Locais já visitados")]
        Visitado = 1
    }
}
