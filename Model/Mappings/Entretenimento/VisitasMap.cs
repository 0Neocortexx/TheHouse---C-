using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Entretenimento;
using Model.Enums.Entretenimento;

namespace Model.Mappings.Entretenimento
{
    public class VisitasMap : IEntityTypeConfiguration<Visitas> 
    {
        public void Configure(EntityTypeBuilder<Visitas> builder) 
        {
            builder.ToTable("Visitas");
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
