using Model.Entities.Usuarios;
using Model.Enums.Metas;

namespace Model.Entities.Metas 
{
    public class Meta
    {
        public int Id { get; set; }
        public string NomeMeta { get; set; }
        public DateTime DataObjetivo { get; set; }
        public decimal ValorAdquirido { get; set; }
        public decimal ValorTotalMeta { get; set; }
        public MetaStatus MetaStatus { get; set; }
        public int UsuarioId { get; set; } // Chave estrangeira para a entidade Usuario
        public Usuario Usuario { get; set; } // Navegação para o usuario que criou a meta

        public Meta() { }

        public Meta(int id, string nomeMeta, DateTime dataMeta, decimal valorAdquirido, decimal valorTotalMeta, MetaStatus metaStatus, int usuarioId)
        {
            Id = id;
            NomeMeta = nomeMeta;
            DataObjetivo = dataMeta;
            ValorAdquirido = valorAdquirido;
            ValorTotalMeta = valorTotalMeta;
            MetaStatus = metaStatus;
            UsuarioId = usuarioId;
        }

    }
}
