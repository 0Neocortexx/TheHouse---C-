using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Metas;
using Model.Enums.Metas;

namespace Model.Mappings.Metas
{
    public class MetaMap : IEntityTypeConfiguration<Meta> {
        public void Configure(EntityTypeBuilder<Meta> builder) {
            builder.ToTable("Metas");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.NomeMeta).HasMaxLength(256);
            builder.Property(e => e.MetaStatus).HasConversion(
                v => v.ToString(),
                v => (MetaStatus)Enum.Parse(typeof(MetaStatus), v)
                );
        } 
    }
}
