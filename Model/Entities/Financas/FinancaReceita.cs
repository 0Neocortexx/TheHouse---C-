using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Financas {
    public class FinancaReceita {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }

        public FinancaReceita() { }

        public FinancaReceita(int id,string motivo,decimal valor,DateTime dataEntrada) {
            Id = id;
            Motivo = motivo;
            Valor = valor;
            DataEntrada = dataEntrada;
        }
    }
}
