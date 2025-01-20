using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Visitas;
using Model.Enums.Visitas;

namespace Model.Mappings.Visitas
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
                v => (EStatusVisita)Enum.Parse(typeof(EStatusVisita), v));
            builder.Property(e => e.DataVisita).IsRequired(false);

        }
    }
}
