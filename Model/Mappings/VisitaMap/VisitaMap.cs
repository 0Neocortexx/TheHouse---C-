using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Visita;
using Model.Enums.Visita;

namespace Model.Mappings.Entretenimento
{
    public class VisitaMap : IEntityTypeConfiguration<Visita> 
    {
        public void Configure(EntityTypeBuilder<Visita> builder) 
        {
            builder.ToTable("Visita");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Local).HasMaxLength(128).IsUnicode(true);
            builder.Property(e => e.StatusVisita).HasConversion(
                v => v.ToString(),
                v => (StatusVisita)Enum.Parse(typeof(StatusVisita), v));
            builder.Property(e => e.DataVisita).IsRequired(false);

        }
    }
}
