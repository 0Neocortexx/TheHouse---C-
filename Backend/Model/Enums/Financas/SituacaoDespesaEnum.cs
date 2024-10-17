using System.ComponentModel;

namespace Model.Enums.Financas {
    public enum SituacaoDespesaEnum {
        [Description("Enumerado que indica status da despesa")]
        EmAberto = 0,
        Pago = 1,
        Vencido = 2
    }
}
