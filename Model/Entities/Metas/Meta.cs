using Model.Enums.Meta;

namespace Model.Entities.Metas {
    public class Meta
    {
        public int Id { get; set; }
        public string NomeMeta { get; set; }
        public DateTime DataMeta { get; set; }
        public decimal ValorAtual { get; set; }
        public decimal ValorFinal { get; set; }
        public MetaStatus MetaStatus { get; set; }

        public Meta() { }

        public Meta(int id, string nomeMeta, DateTime dataMeta, decimal valorAtual, decimal valorFinal, MetaStatus metaStatus)
        {
            Id = id;
            NomeMeta = nomeMeta;
            DataMeta = dataMeta;
            ValorAtual = valorAtual;
            ValorFinal = valorFinal;
            MetaStatus = metaStatus;
        }

    }
}
