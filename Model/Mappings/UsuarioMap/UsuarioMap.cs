using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Usuario;
using Model.Enums.Usuario;

namespace Model.Mappings.UsuarioMap
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasMaxLength(128);
            builder.Property(e => e.Email).HasMaxLength(256);
            builder.Property(e => e.Genero).HasConversion(
                v => v.ToString(),
                v => (GeneroEnum)Enum.Parse(typeof(GeneroEnum), v)
                );
            
        }
    } 
}
