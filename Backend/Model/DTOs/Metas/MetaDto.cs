using Model.Enums.Metas;

namespace Model.DTOs.Metas
{
    public class MetaDto
    {
        public int? Id { get; set; }
        public string? NomeMeta { get; set; }
        public string? DataObjetivo { get; set; }
        public string? ValorAdquirido { get; set; }
        public string? ValorTotalMeta { get; set; }
        public MetaStatus? MetaStatus { get; set; }
        public int? UsuarioId { get; set; }
    }

    public class CreateMetaDto
    {
        public string? NomeMeta { get; set; }
        public string? DataObjetivo { get; set; }
        public string? ValorAdquirido { get; set; }
        public string? ValorTotalMeta { get; set; }
        public MetaStatus? MetaStatus { get; set; }
        public int? UsuarioId { get; set; }
    }
}
