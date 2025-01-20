using System.ComponentModel;

namespace Model.Enums.Metas {
    public enum MetaStatus {
        [Description ("Metas não concluídas")]
        NaoConcluida = 0,
        [Description ("Metas Concluídas")]
        Concluida = 1,
        [Description ("Metas em planejamento")]
        EmPlanjamento = 2
    }
}
