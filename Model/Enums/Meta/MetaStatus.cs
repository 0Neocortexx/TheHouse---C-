using System.ComponentModel;

namespace Model.Enums.Meta {
    public enum MetaStatus {
        [Description ("Status das metas")]
        NaoConcluida = 0,
        Concluida = 1,
        EmPlanjamento = 2
    }
}
