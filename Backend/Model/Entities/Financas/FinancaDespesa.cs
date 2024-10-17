using Model.Enums.Financas;

namespace Model.Entities.Financas {
    public class FinancaDespesa {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataVencimento { get; set; }
        public SituacaoDespesaEnum SituacaoDespesaEnum { get; set; }

        public FinancaDespesa() { }

        public FinancaDespesa(int id,string motivo,decimal valor,DateTime dataInicio,DateTime dataVencimento,SituacaoDespesaEnum situacaoDespesaEnum) {
            this.Id = id;
            this.Motivo = motivo;
            this.Valor = valor;
            this.DataInicio = dataInicio;
            this.DataVencimento = dataVencimento;
            this.SituacaoDespesaEnum = situacaoDespesaEnum;
        }
    }
}