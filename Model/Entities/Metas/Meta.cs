using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Metas
{
    public class Meta
    {
        public int Id { get; set; }
        public string NomeMeta { get; set; }
        public DateTime DataMeta { get; set; }
        public decimal ValorAtual { get; set; }
        public decimal ValorFinal { get; set; }
        public bool Status { get; set; }
        public Meta() { }

        public Meta(int id, string nomeMeta, DateTime dataMeta, decimal valorAtual, decimal valorFinal, bool status)
        {
            Id = id;
            NomeMeta = nomeMeta;
            DataMeta = dataMeta;
            ValorAtual = valorAtual;
            ValorFinal = valorFinal;
            Status = status;
        }

    }
}
