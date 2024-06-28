using Model.Enums.Financas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Financas
{
    public class Financa
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public decimal Valor { get; set; }
        public TipoFinanca TipoFinanca { get; set; }
        
        public Financa() { }

        public Financa(int id, string motivo, decimal valor, TipoFinanca tipoFinanca) { 
            this.Id = id;
            this.Motivo = motivo;
            this.Valor = valor;
            this.TipoFinanca = tipoFinanca;
        }

    }
}
