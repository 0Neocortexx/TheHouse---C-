using System.ComponentModel;

namespace Model.Enums.Financas {
    public enum TipoFinanca {
        [Description ("Tipo finanças, podem ser receitas e despesas")] 
        Despesa = 0,
        RECEITA = 1
    }
}
