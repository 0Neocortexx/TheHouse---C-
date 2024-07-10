using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enums.Entretenimento
{
    public enum StatusVisita
    {
        [Description ("Define os status das visitas")]
        NaoVisitado = 0,
        Visitado = 1
    }
}
