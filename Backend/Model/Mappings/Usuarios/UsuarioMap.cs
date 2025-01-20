using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Usuarios;

namespace Model.Mappings.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.Property(u => u.Email)
                .HasMaxLength(128);   
        }
    } 
}
